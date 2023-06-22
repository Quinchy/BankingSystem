using BankingSystem.Database;
using BankingSystem.Models.CustomerModels;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Services.CustomerServices
{
    internal class TransactionHistoryServices
    {
        public static List<Transaction> RetrieveTransactions(string email, int limit = 6, int offset = 0)
        {
            List<Transaction> transactions = new List<Transaction>();
            // Open a connection to the MySQL database
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                // SQL query to retrieve transactions
                string sql = @"
                    SELECT th.transaction_id, th.amount, th.date, th.transaction_type
                    FROM transaction_history th
                    JOIN account a ON th.account_id = a.account_id
                    JOIN customer_information ci ON a.customer_id = ci.customer_id
                    WHERE ci.email = @Email
                    ORDER BY th.date DESC
                    LIMIT @Limit
                    OFFSET @Offset";
                MySqlCommand command = new MySqlCommand(sql, connection);
                // Use the email and limit parameters in the SQL query
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Limit", limit);
                command.Parameters.AddWithValue("@Offset", offset);
                // Execute the command and process the results
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Transaction transaction = new Transaction(
                            reader.GetString("transaction_id"),
                            reader.GetDouble("amount"),
                            reader.GetDateTime("date"),
                            reader.GetString("transaction_type")
                        );
                        transactions.Add(transaction);
                    }
                }
            }
            return transactions;
        }
        public static int GetTransactionCount(string email)
        {
            int count = 0;
            // Open a connection to the MySQL database
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                // SQL query to count transactions
                string sql = @"
                    SELECT COUNT(*)
                    FROM transaction_history th
                    JOIN account a ON th.account_id = a.account_id
                    JOIN customer_information ci ON a.customer_id = ci.customer_id
                    WHERE ci.email = @Email";
                MySqlCommand command = new MySqlCommand(sql, connection);
                // Use the email parameter in the SQL query
                command.Parameters.AddWithValue("@Email", email);
                // Execute the command and process the result
                count = Convert.ToInt32(command.ExecuteScalar());
            }
            return count;
        }
        // Generate a transaction receipt and save in the database
        public static void GenerateReceiptForTransaction(Transaction transaction)
        {
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                // SQL query to get the customer ID and account ID for a transaction
                string sqlFetch = @"
            SELECT a.account_id, a.customer_id
            FROM account a
            JOIN transaction_history th ON a.account_id = th.account_id
            WHERE th.transaction_id = @TransactionId";
                MySqlCommand commandFetch = new MySqlCommand(sqlFetch, connection);
                commandFetch.Parameters.AddWithValue("@TransactionId", transaction.TransactionId);

                string accountId = null;
                string customerId = null;

                // Execute the command and process the results
                using (MySqlDataReader reader = commandFetch.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        accountId = reader.GetString("account_id");
                        customerId = reader.GetString("customer_id");
                    }
                }

                if (accountId != null && customerId != null)
                {
                    // Check if receipt already exists
                    string sqlCheck = @"
                SELECT COUNT(*)
                FROM transaction_receipt
                WHERE transaction_id = @TransactionId";
                    MySqlCommand commandCheck = new MySqlCommand(sqlCheck, connection);
                    commandCheck.Parameters.AddWithValue("@TransactionId", transaction.TransactionId);

                    var receiptExists = Convert.ToInt32(commandCheck.ExecuteScalar()) > 0;

                    if (!receiptExists)
                    {
                        // SQL query to insert into transaction receipt
                        string sqlInsert = @"
                INSERT INTO transaction_receipt (reference_number, customer_id, account_id, transaction_id)
                VALUES (@ReferenceNumber, @CustomerId, @AccountId, @TransactionId)";
                        MySqlCommand commandInsert = new MySqlCommand(sqlInsert, connection);
                        commandInsert.Parameters.AddWithValue("@ReferenceNumber", GenerateReferenceNumber());
                        commandInsert.Parameters.AddWithValue("@CustomerId", customerId);
                        commandInsert.Parameters.AddWithValue("@AccountId", accountId);
                        commandInsert.Parameters.AddWithValue("@TransactionId", transaction.TransactionId);
                        commandInsert.ExecuteNonQuery();
                    }
                }
            }
        }

        private static string GenerateReferenceNumber()
        {
            Random rnd = new Random();
            return string.Format("{0:D4}-{1:D3}-{2:D4}", rnd.Next(0, 9999), rnd.Next(0, 999), rnd.Next(0, 9999));
        }
        public static Receipt GetReceiptFromDatabase(string transactionId)
        {
            Receipt receipt = null;

            // Open a connection to the MySQL database
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                // SQL query to retrieve receipt
                string sql = @"
                    SELECT tr.reference_number, CONCAT(ci.first_name, ' ', ci.last_name) AS full_name, tr.account_id, th.transaction_type, th.amount, th.date
                    FROM transaction_receipt tr
                    JOIN transaction_history th ON tr.transaction_id = th.transaction_id
                    JOIN account a ON th.account_id = a.account_id
                    JOIN customer_information ci ON a.customer_id = ci.customer_id
                    WHERE tr.transaction_id = @TransactionId";
                MySqlCommand command = new MySqlCommand(sql, connection);
                // Use the transactionId parameter in the SQL query
                command.Parameters.AddWithValue("@TransactionId", transactionId);

                // Execute the command and process the results
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        receipt = new Receipt(
                            reader.GetString("full_name"), // Will return "first_name last_name"
                            reader.GetString("account_id"),
                            reader.GetString("transaction_type"),
                            reader.GetDouble("amount"),
                            reader.GetString("reference_number"),
                            reader.GetDateTime("date")
                        );
                    }
                }
            }
            return receipt;
        }
    }
}
