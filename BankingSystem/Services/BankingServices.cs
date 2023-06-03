using BankingSystem.Database;
using BankingSystem.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Services
{
    internal class BankingServices
    {
        public static Tuple<Account, List<Transaction>> loadAccountInformation(string email)
        {
            Account currentAccount = null;
            List<Transaction> transactions = new List<Transaction>();
            using (MySqlConnection conn = MySQLDatabase.OpenConnection())
            {
                if (conn == null)
                {
                    Console.WriteLine("Unable to open MySQL connection.");
                    return null;
                }
                // Assuming email is unique
                MySqlCommand command = new MySqlCommand("SELECT * FROM Account WHERE customer_id = (SELECT customer_id FROM Customer WHERE email = @Email)", conn);
                command.Parameters.AddWithValue("@Email", email);
                string accountId = "";
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        accountId = reader["account_id"].ToString();
                        double balance = Convert.ToDouble(reader["balance"]);

                        currentAccount = new Account(accountId, balance);
                    }
                }
                // Retrieve last five transactions
                if (!String.IsNullOrEmpty(accountId))
                {
                    MySqlCommand transactionCommand = new MySqlCommand("SELECT * FROM (SELECT * FROM Transaction WHERE account_id = @AccountId ORDER BY date DESC) sub ORDER BY date DESC LIMIT 5", conn);
                    transactionCommand.Parameters.AddWithValue("@AccountId", accountId);
                    using (MySqlDataReader transactionReader = transactionCommand.ExecuteReader())
                    {
                        while (transactionReader.Read())
                        {
                            string transactionId = transactionReader["transaction_id"].ToString();
                            double amount = Convert.ToDouble(transactionReader["amount"]);
                            DateTime date = Convert.ToDateTime(transactionReader["date"]);
                            string transactionType = transactionReader["transaction_type"].ToString();
                            Transaction transaction = new Transaction(transactionId, amount, transactionType);
                            transactions.Add(transaction);
                        }
                    }
                }
                MySQLDatabase.CloseConnection(conn);
            }
            return Tuple.Create(currentAccount, transactions);
        }
        public static string GetCustomerFirstName(string email)
        {
            string firstName = null;
            using (MySqlConnection conn = MySQLDatabase.OpenConnection())
            {
                if (conn == null)
                {
                    Console.WriteLine("Unable to open MySQL connection.");
                    return null;
                }
                // Assuming email is unique
                MySqlCommand command = new MySqlCommand("SELECT first_name FROM Customer WHERE email = @Email", conn);
                command.Parameters.AddWithValue("@Email", email);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        firstName = reader["first_name"].ToString();
                    }
                }
                MySQLDatabase.CloseConnection(conn);
            }
            return firstName;
        }
    }
}
