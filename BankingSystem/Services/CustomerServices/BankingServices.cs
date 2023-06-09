using BankingSystem.Database;
using BankingSystem.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Services.CustomerServices
{
    internal class BankingServices
    {
        public static Tuple<Account, List<Transaction>> LoadAccountInformation(string email)
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
                MySqlCommand command = new MySqlCommand("SELECT * FROM Account WHERE customer_id = (SELECT customer_id FROM customer_information WHERE email = @Email)", conn);
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
                // Retrieve last ten transactions
                if (!string.IsNullOrEmpty(accountId))
                {
                    MySqlCommand transactionCommand = new MySqlCommand("SELECT transaction_id, amount, DATE_FORMAT(date, '%Y-%m-%d') AS date, transaction_type FROM (SELECT * FROM transaction_history WHERE account_id = @AccountId ORDER BY date DESC LIMIT 10) sub ORDER BY date DESC", conn);
                    transactionCommand.Parameters.AddWithValue("@AccountId", accountId);
                    using (MySqlDataReader transactionReader = transactionCommand.ExecuteReader())
                    {
                        while (transactionReader.Read())
                        {
                            string transactionId = transactionReader["transaction_id"].ToString();
                            double amount = Convert.ToDouble(transactionReader["amount"]);
                            DateTime date = DateTime.Parse(transactionReader["date"].ToString());
                            string transactionType = transactionReader["transaction_type"].ToString();
                            Transaction transaction = new Transaction(transactionId, amount, date,transactionType);
                            transactions.Add(transaction);
                        }
                    }
                }
                MySQLDatabase.CloseConnection(conn);
            }
            return Tuple.Create(currentAccount, transactions);
        }
        public static bool isTheirAccount(string email, string accountId)
        {
            using (var conn = MySQLDatabase.OpenConnection())
            {
                string query = @"SELECT 1 
                                FROM Account a
                                JOIN Customer_information c ON a.customer_id = c.customer_id
                                WHERE c.email = @email AND a.account_id = @accountId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@accountId", accountId);
                object result = cmd.ExecuteScalar();
                return result != null;
            }
        }
        public static void requestDeposit(string accountId, double depositAmount)
        {
            using (var conn = MySQLDatabase.OpenConnection())
            {
                string query = "INSERT INTO transaction_processing (account_id, transaction_type, amount, process_status) VALUES (@accountId, 'Deposit', @amount, 'Pending')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@accountId", accountId);
                cmd.Parameters.AddWithValue("@amount", depositAmount);
                cmd.ExecuteNonQuery();
            }
        }
        public static void requestWithdraw(string accountId, double withdrawAmount)
        {
            using (var conn = MySQLDatabase.OpenConnection())
            {
                string query = "INSERT INTO transaction_processing (account_id, transaction_type, amount, process_status) VALUES (@accountId, 'Withdraw', @amount, 'Pending')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@accountId", accountId);
                cmd.Parameters.AddWithValue("@amount", withdrawAmount);
                cmd.ExecuteNonQuery();
            }
        }

        public static void transferMoney(string senderAccountId, string receiverAccountId, double transferAmount)
        {
            using (var conn = MySQLDatabase.OpenConnection())
            {
                // First, try to withdraw from the sender's account
                string query = "SELECT balance FROM Account WHERE account_id = @accountId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@accountId", senderAccountId);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    double currentBalance = Convert.ToDouble(result);
                    double newBalance = currentBalance - transferAmount;
                    query = "UPDATE Account SET balance = @balance WHERE account_id = @accountId";
                    cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@accountId", senderAccountId);
                    cmd.Parameters.AddWithValue("@balance", newBalance);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Sender's Account ID not found.");
                    return;
                }
                // Then, try to deposit to the receiver's account
                query = "SELECT balance FROM Account WHERE account_id = @accountId";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@accountId", receiverAccountId);
                result = cmd.ExecuteScalar();
                if (result != null)
                {
                    double currentBalance = Convert.ToDouble(result);
                    double newBalance = currentBalance + transferAmount;
                    query = "UPDATE Account SET balance = @balance WHERE account_id = @accountId";
                    cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@accountId", receiverAccountId);
                    cmd.Parameters.AddWithValue("@balance", newBalance);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Receiver's Account ID not found.");
                    return;
                }
            }
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
                MySqlCommand command = new MySqlCommand("SELECT first_name FROM customer_information WHERE email = @Email", conn);
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
