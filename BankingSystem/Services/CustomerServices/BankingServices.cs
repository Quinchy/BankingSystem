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
    internal class BankingServices
    {
        // This method retrieves the first name of a customer using their email.
        public static string retrieveCustomerFirstName(string email)
        {
            // Initialize the first name as null.
            string firstName = null;
            // Open a connection to the MySQL database.
            using (MySqlConnection conn = MySQLDatabase.OpenConnection())
            {
                // If the connection is null, print an error message and return null.
                if (conn == null)
                {
                    Console.WriteLine("Unable to open MySQL connection.");
                    return null;
                }
                // Create a new SQL command to select the first name from the customer_information table where the email matches the provided email.
                MySqlCommand command = new MySqlCommand("SELECT first_name FROM customer_information WHERE email = @Email", conn);
                command.Parameters.AddWithValue("@Email", email);
                // Execute the command and read the result.
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // If the reader can read the result, set the first name to the first name in the result.
                    if (reader.Read())
                    {
                        firstName = reader["first_name"].ToString();
                    }
                }
            }
            // Return the first name.
            return firstName;
        }
        // Retrieves the balance of a customer's account using their email.
        public static double retrieveAccountBalance(string email)
        {
            // Initialize balance to 0
            double balance = 0;
            // Open a new MySQL connection
            using (MySqlConnection conn = MySQLDatabase.OpenConnection())
            {
                // If connection is null, print an error message and return balance (which is 0)
                if (conn == null)
                {
                    Console.WriteLine("Unable to open MySQL connection.");
                    return balance;
                }
                // Prepare a MySQL command to select the balance of the account associated with the given email
                MySqlCommand command = new MySqlCommand("SELECT balance FROM Account WHERE customer_id = (SELECT customer_id FROM customer_information WHERE email = @Email)", conn);
                command.Parameters.AddWithValue("@Email", email);
                // Execute the command and read the result
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // If there is a result, set balance to the retrieved balance
                    if (reader.Read())
                    {
                        balance = Convert.ToDouble(reader["balance"]);
                    }
                }
            }
            // Return the retrieved balance (or 0 if no balance was retrieved)
            return balance;
        }
        // Retrieves the account ID of a customer using their email.
        public static string retrieveAccountId(string email)
        {
            string accountId = null;
            using (MySqlConnection conn = MySQLDatabase.OpenConnection())
            {
                if (conn == null)
                {
                    Console.WriteLine("Unable to open MySQL connection.");
                    return null;
                }
                // Prepare the SQL command to fetch the account id
                MySqlCommand command = new MySqlCommand("SELECT account_id FROM account WHERE customer_id = (SELECT customer_id FROM customer_information WHERE email = @Email)", conn);
                command.Parameters.AddWithValue("@Email", email);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // If the reader has data, assign the account id
                    if (reader.Read())
                    {
                        accountId = reader["account_id"].ToString();
                    }
                }
            }
            return accountId;
        }
        // Retrieves the transaction history of an account using the account ID.
        public static List<Transaction> retrieveAccountTransactionHistory(string accountId)
        {
            List<Transaction> transactions = new List<Transaction>();
            using (MySqlConnection conn = MySQLDatabase.OpenConnection())
            {
                if (conn == null)
                {
                    Console.WriteLine("Unable to open MySQL connection.");
                    return null;
                }
                // If account id is not null or empty, prepare the SQL command to fetch the transaction history
                if (!string.IsNullOrEmpty(accountId))
                {
                    MySqlCommand transactionCommand = new MySqlCommand("SELECT transaction_id, amount, DATE_FORMAT(date, '%Y-%m-%d') AS date, transaction_type FROM (SELECT * FROM transaction_history WHERE account_id = @AccountId ORDER BY date DESC LIMIT 10) sub ORDER BY date DESC", conn);
                    transactionCommand.Parameters.AddWithValue("@AccountId", accountId);
                    using (MySqlDataReader transactionReader = transactionCommand.ExecuteReader())
                    {
                        // For each record, create a new Transaction object and add it to the transactions list
                        while (transactionReader.Read())
                        {
                            string transactionId = transactionReader["transaction_id"].ToString();
                            double amount = Convert.ToDouble(transactionReader["amount"]);
                            DateTime date = DateTime.Parse(transactionReader["date"].ToString());
                            string transactionType = transactionReader["transaction_type"].ToString();
                            Transaction transaction = new Transaction(transactionId, amount, date, transactionType);
                            transactions.Add(transaction);
                        }
                    }
                }
            }
            return transactions;
        }
        // Check if the account id they provided is theirs.
        public static bool isTheirAccount(string email, string accountId)
        {
            // Open a connection to the MySQL database using a connection pool
            using (var conn = MySQLDatabase.OpenConnection())
            {
                // Construct the SQL query to check for a matching email and account ID
                string query = @"SELECT 1 
                    FROM Account a
                    JOIN Customer_information c ON a.customer_id = c.customer_id
                    WHERE c.email = @email AND a.account_id = @accountId";
                // Create a MySqlCommand object with the query and connection
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Add parameters to the query to prevent SQL injection
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@accountId", accountId);
                    // Execute the query and retrieve the result
                    object result = cmd.ExecuteScalar();
                    // Return true if a result is found, otherwise false
                    return result != null;
                }
            }
        }
        // Checks if a receiver ID exists in the database
        public static bool isReceiverIDExist(string receiverID)
        {
            // Open a connection to the MySQL database using a connection pool
            using (var conn = MySQLDatabase.OpenConnection())
            {
                // Construct the SQL query to check if the receiver ID exists
                string query = "SELECT EXISTS(SELECT 1 FROM account WHERE account_id = @ReceiverID)";
                // Create a MySqlCommand object with the query and connection
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    // Add the receiver ID as a parameter to the query to prevent SQL injection
                    command.Parameters.AddWithValue("@ReceiverID", receiverID);
                    // Execute the query and retrieve the result
                    object result = command.ExecuteScalar();
                    // Convert the result to a boolean value and return it
                    return Convert.ToBoolean(result);
                }
            }
        }
        // Requests a deposit transaction for a given account ID and amount
        public static void requestDeposit(string accountId, double depositAmount)
        {
            // Open a connection to the MySQL database using a connection pool
            using (var conn = MySQLDatabase.OpenConnection())
            {
                // Construct the SQL query to insert a deposit transaction
                string query = "INSERT INTO transaction_processing (account_id, transaction_type, amount, process_status) VALUES (@accountId, 'Deposit', @amount, 'Pending')";
                // Create a MySqlCommand object with the query and connection
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Add parameters to the query to prevent SQL injection
                    cmd.Parameters.AddWithValue("@accountId", accountId);
                    cmd.Parameters.AddWithValue("@amount", depositAmount);
                    // Execute the query to insert the deposit transaction
                    cmd.ExecuteNonQuery();
                }
            }
        }
        // Requests a withdrawal transaction for a given account ID and amount
        public static void requestWithdraw(string accountId, double withdrawAmount)
        {
            // Open a connection to the MySQL database using a connection pool
            using (var conn = MySQLDatabase.OpenConnection())
            {
                // Construct the SQL query to insert a withdrawal transaction
                string query = "INSERT INTO transaction_processing (account_id, transaction_type, amount, process_status) VALUES (@accountId, 'Withdraw', @amount, 'Pending')";
                // Create a MySqlCommand object with the query and connection
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Add parameters to the query to prevent SQL injection
                    cmd.Parameters.AddWithValue("@accountId", accountId);
                    cmd.Parameters.AddWithValue("@amount", withdrawAmount);
                    // Execute the query to insert the withdrawal transaction
                    cmd.ExecuteNonQuery();
                }
            }
        }
        // Requests a transfer transaction from the sender account to the receiver account with a given amount
        public static void requestTransfer(string senderAccountId, string receiverAccountId, double transferAmount)
        {
            // Open a connection to the MySQL database using a connection pool
            using (var conn = MySQLDatabase.OpenConnection())
            {
                // Construct the SQL query to insert a transfer transaction
                string query = "INSERT INTO transaction_processing (account_id, transaction_type, amount, process_status, receiver_account_id) VALUES (@accountId, 'Transfer', @amount, 'Pending', @receiverAccountId)";
                // Create a MySqlCommand object with the query and connection
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Add parameters to the query to prevent SQL injection
                    cmd.Parameters.AddWithValue("@accountId", senderAccountId);
                    cmd.Parameters.AddWithValue("@amount", transferAmount);
                    cmd.Parameters.AddWithValue("@receiverAccountId", receiverAccountId);
                    // Execute the query to insert the transfer transaction
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
