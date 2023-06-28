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
    // A service class for sending transaction request like withdraw, deposit and transfer. Also retrieves information for Home Screen Form.
    internal class BankingServices
    {
        // This method retrieves the first name of a customer using their email.
        public static string RetrieveCustomerFirstName(string email)
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
        public static double RetrieveAccountBalance(string email)
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
        // Check if the account id they provided is theirs.
        public static bool IsTheirAccount(string email, string accountId)
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
        public static bool CheckPendingRequests(string email)
        {
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                if (connection != null)
                {
                    try
                    {
                        string query = @"SELECT tp.process_id 
                                 FROM transaction_processing tp 
                                 JOIN account a ON tp.sender_account_id = a.account_id
                                 JOIN customer_information ci ON a.customer_id = ci.customer_id
                                 WHERE ci.email = @Email AND tp.process_status = 'Pending'";

                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@Email", email);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    // There are pending requests
                                    return true;
                                }
                                else
                                {
                                    // There are no pending requests
                                    return false;
                                }
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
        public static List<Notification> GetUnseenNotifications(int customerId)
        {
            List<Notification> notifications = new List<Notification>();

            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                string query = "SELECT * FROM notifications WHERE customer_id = @customerId AND is_seen = 0";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@customerId", customerId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Notification notification = new Notification(
                                reader.GetInt32(0),  // Assuming Id is at index 0
                                reader.GetInt32(1),  // Assuming CustomerId is at index 1
                                reader.GetString(2),  // Assuming Message is at index 2
                                reader.GetBoolean(3),  // Assuming IsSeen is at index 4 and is stored as a boolean
                                reader.GetDateTime(4)  // Assuming CreatedAt is at index 3
                            );

                            notifications.Add(notification);
                        }
                    }
                }
            }

            return notifications;
        }
        // Checks if a receiver ID exists in the database
        public static bool IsReceiverIDExist(string receiverID)
        {
            // Open a connection to the MySQL database using a connection pool
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                // Construct the SQL query to check if the receiver ID exists
                string query = "SELECT EXISTS(SELECT 1 FROM account WHERE account_id = @ReceiverID)";
                // Create a MySqlCommand object with the query and connection
                using (MySqlCommand command = new MySqlCommand(query, connection))
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
        public static void RequestDeposit(string accountId, double depositAmount)
        {
            // Open a connection to the MySQL database using a connection pool
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                // Construct the SQL query to insert a deposit transaction
                string query = "INSERT INTO transaction_processing (sender_account_id, transaction_type, amount, process_status) VALUES (@accountId, 'Deposit', @amount, 'Pending')";
                // Create a MySqlCommand object with the query and connection
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
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
        public static void RequestWithdraw(string accountId, double withdrawAmount)
        {
            // Open a connection to the MySQL database using a connection pool
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                // Construct the SQL query to insert a withdrawal transaction
                string query = "INSERT INTO transaction_processing (sender_account_id, transaction_type, amount, process_status) VALUES (@accountId, 'Withdraw', @amount, 'Pending')";
                // Create a MySqlCommand object with the query and connection
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
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
        public static void RequestTransfer(string senderAccountId, string receiverAccountId, double transferAmount)
        {
            // Open a connection to the MySQL database using a connection pool
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                // Construct the SQL query to insert a transfer transaction
                string query = "INSERT INTO transaction_processing (sender_account_id, transaction_type, amount, process_status, receiver_account_id) VALUES (@senderAccountId, 'Transfer', @amount, 'Pending', @receiverAccountId)";
                // Create a MySqlCommand object with the query and connection
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Add parameters to the query to prevent SQL injection
                    cmd.Parameters.AddWithValue("@senderAccountId", senderAccountId);
                    cmd.Parameters.AddWithValue("@amount", transferAmount);
                    cmd.Parameters.AddWithValue("@receiverAccountId", receiverAccountId);
                    // Execute the query to insert the transfer transaction
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void CreateNotification(int customerId, string message)
        {
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                string query = "INSERT INTO notifications(customer_id, message, created_at) VALUES (@customerId, @message, @createdAt)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    cmd.Parameters.AddWithValue("@message", message);
                    cmd.Parameters.AddWithValue("@createdAt", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void DeleteNotification(int notificationId)
        {
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                string query = "DELETE FROM notifications WHERE notification_id = @notificationId";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@notificationId", notificationId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static int RetrieveCustomerId(string email)
        {
            int customerId = 0;

            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                string query = "SELECT customer_id FROM customer_information WHERE email = @Email";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Email", email);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            customerId = reader.GetInt32(0);  // Assuming customer_id is at index 0
                        }
                    }
                }
            }

            return customerId;
        }
        public static void UpdateLastActivityDate(string email)
        {
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                string query = "UPDATE account " +
                               "JOIN customer_information ON account.customer_id = customer_information.customer_id " +
                               "SET account.last_activity_date = CURDATE() " +
                               "WHERE customer_information.email = @email";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@email", email);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
