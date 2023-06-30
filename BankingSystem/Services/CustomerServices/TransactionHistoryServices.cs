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
    // This class contains all the method used by TransactionHistoryForm
    internal class TransactionHistoryServices
    {
        public static List<Transaction> RetrieveTransactions(string email, int limit = 6, int offset = 0)
        {
            List<Transaction> transactions = new List<Transaction>();
            // Open MySQL connection
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                // SQL query that selects all transaction of the user including when they are the receiver.
                string sql = @"
                    (SELECT th.transaction_id, th.amount, th.date, th.transaction_type
                    FROM transaction_history th
                    JOIN account a ON th.sender_account_id = a.account_id
                    JOIN customer_information ci ON a.customer_id = ci.customer_id
                    WHERE ci.email = @Email)
                    UNION ALL
                    (SELECT th.transaction_id, th.amount, th.date, th.transaction_type
                    FROM transaction_history th
                    JOIN account a ON th.receiver_account_id = a.account_id
                    JOIN customer_information ci ON a.customer_id = ci.customer_id
                    WHERE ci.email = @Email)
                    ORDER BY transaction_id DESC
                    LIMIT @Limit
                    OFFSET @Offset";
                MySqlCommand command = new MySqlCommand(sql, connection);
                // Add parameters to the query
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Limit", limit);
                command.Parameters.AddWithValue("@Offset", offset);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // Iterate through the results and create a new transaction object for each one
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
            // Returns the list of transaction
            return transactions;
        }
        // Counts the number of transaction the customer has.
        public static int GetTransactionCount(string email)
        {
            int count = 0;
            // Open MySQL connection
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                // SQL query to count transactions
                string sql = @"
                    SELECT COUNT(*)
                    FROM (
                        SELECT th.transaction_id
                        FROM transaction_history th
                        JOIN account a ON th.sender_account_id = a.account_id
                        JOIN customer_information ci ON a.customer_id = ci.customer_id
                        WHERE ci.email = @Email
                        UNION ALL
                        SELECT th.transaction_id
                        FROM transaction_history th
                        JOIN account a ON th.receiver_account_id = a.account_id
                        JOIN customer_information ci ON a.customer_id = ci.customer_id
                        WHERE ci.email = @Email
                    ) AS total";
                MySqlCommand command = new MySqlCommand(sql, connection);
                // Add parameters to the query
                command.Parameters.AddWithValue("@Email", email);
                // Execute the command and process the result
                count = Convert.ToInt32(command.ExecuteScalar());
            }
            return count;
        }
    }
}
