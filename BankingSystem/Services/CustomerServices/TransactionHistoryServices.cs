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
    }
}
