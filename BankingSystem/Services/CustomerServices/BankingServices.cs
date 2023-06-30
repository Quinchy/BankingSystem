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
    // This class contains all the methods used by HomeScreenForm.
    internal class BankingServices
    {
        // This method retrieves the first name of a customer using their email.
        public static string RetrieveCustomerFirstName(string email)
        {
            string firstName = null;
            // Open MySQL connection
            using (MySqlConnection conn = MySQLDatabase.OpenConnection())
            {
                // SQL query to select the first name from the customer_information table where the email matches the provided email.
                MySqlCommand command = new MySqlCommand("SELECT first_name FROM customer_information WHERE email = @Email", conn);
                // Add parameters to the query
                command.Parameters.AddWithValue("@Email", email);
                // Execute the command and read the result.
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // Set the first name to the first name in the result.
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
            double balance = 0;
            // Open MySQL connection
            using (MySqlConnection conn = MySQLDatabase.OpenConnection())
            {
                // SQL query to select the balance of the account from account associated with the given email
                MySqlCommand command = new MySqlCommand("SELECT balance FROM Account WHERE customer_id = (SELECT customer_id FROM customer_information WHERE email = @Email)", conn);
                // Add parameters to the query
                command.Parameters.AddWithValue("@Email", email);
                // Execute the command and read the result
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // Set balance to the retrieved balance
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
            // Open MySQL connection
            using (var conn = MySQLDatabase.OpenConnection())
            {
                // SQL query to check for a matching email and account ID
                string query = @"SELECT 1 
                    FROM Account a
                    JOIN Customer_information c ON a.customer_id = c.customer_id
                    WHERE c.email = @email AND a.account_id = @accountId";
                // Create a MySqlCommand object with the query and connection
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Add parameters to the query
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@accountId", accountId);
                    // Execute the query and retrieve the result
                    object result = cmd.ExecuteScalar();
                    // Return true if a result is found, otherwise false
                    return result != null;
                }
            }
        }
        // Check if there is existing request
        public static bool CheckPendingRequests(string email)
        {
            // Open MySQL connection
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                // SQL query to check if there is pending request associated with the email.
                string query = @"SELECT tp.process_id 
                            FROM transaction_processing tp 
                            JOIN account a ON tp.sender_account_id = a.account_id
                            JOIN customer_information ci ON a.customer_id = ci.customer_id
                            WHERE ci.email = @Email AND tp.process_status = 'Pending'";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Add parameter to the query
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
        }
        // Retrieve a list of unseen notifications.
        public static List<Notification> GetUnseenNotifications(int customerId)
        {
            List<Notification> notifications = new List<Notification>();

            // Open MySQL connection
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                // SQL query to select all notifications for the specified customer ID that have not been seen.
                string query = "SELECT * FROM notifications WHERE customer_id = @customerId AND is_seen = 0";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Iterate through the results and create a notification object for each one.
                        while (reader.Read())
                        {
                            Notification notification = new Notification(
                                reader.GetInt32(0),  
                                reader.GetInt32(1), 
                                reader.GetString(2), 
                                reader.GetBoolean(3), 
                                reader.GetDateTime(4) 
                            );
                            notifications.Add(notification);
                        }
                    }
                }
            }
            // Return the list of notifications.
            return notifications;
        }
        // Checks if a receiver ID exists in the database
        public static bool IsReceiverIDExist(string receiverID)
        {
            // Open MySQL connection
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                // SQL query to check if the receiver ID exists
                string query = "SELECT EXISTS(SELECT 1 FROM account WHERE account_id = @ReceiverID)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Add parameter to the query
                    command.Parameters.AddWithValue("@ReceiverID", receiverID);
                    object result = command.ExecuteScalar();
                    // Convert the result to a boolean value and return it
                    return Convert.ToBoolean(result);
                }
            }
        }
        // Creates a deposit request.
        public static void RequestDeposit(string accountId, double depositAmount)
        {
            // Open MySQL connection
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                // SQL query to insert a deposit transaction
                string query = "INSERT INTO transaction_processing (sender_account_id, transaction_type, amount, process_status) " +
                    "VALUES (@accountId, 'Deposit', @amount, 'Pending')";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Add parameters to the query
                    cmd.Parameters.AddWithValue("@accountId", accountId);
                    cmd.Parameters.AddWithValue("@amount", depositAmount);
                    // Execute the query to insert the deposit transaction
                    cmd.ExecuteNonQuery();
                }
            }
        }
        // Create a withdrawal request.
        public static void RequestWithdraw(string accountId, double withdrawAmount)
        {
            // Open MySQL connection
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                // SQL query to insert a withdrawal request
                string query = "INSERT INTO transaction_processing (sender_account_id, transaction_type, amount, process_status) " +
                    "VALUES (@accountId, 'Withdraw', @amount, 'Pending')";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Add parameters to the query
                    cmd.Parameters.AddWithValue("@accountId", accountId);
                    cmd.Parameters.AddWithValue("@amount", withdrawAmount);
                    // Execute the query to insert the withdrawal transaction
                    cmd.ExecuteNonQuery();
                }
            }
        }
        // Create a transfer request
        public static void RequestTransfer(string senderAccountId, string receiverAccountId, double transferAmount)
        {
            // Open MySQL connection
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                // Construct the SQL query to insert a transfer transaction
                string query = "INSERT INTO transaction_processing (sender_account_id, transaction_type, amount, process_status, receiver_account_id) " +
                    "VALUES (@senderAccountId, 'Transfer', @amount, 'Pending', @receiverAccountId)";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Add parameters to the query
                    cmd.Parameters.AddWithValue("@senderAccountId", senderAccountId);
                    cmd.Parameters.AddWithValue("@amount", transferAmount);
                    cmd.Parameters.AddWithValue("@receiverAccountId", receiverAccountId);
                    // Execute the query to insert the transfer transaction
                    cmd.ExecuteNonQuery();
                }
            }
        }
        // Deletes notification from the table
        public static void DeleteNotification(int notificationId)
        {
            // Open MySQL connection
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                string query = "DELETE FROM notifications WHERE notification_id = @notificationId";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Add parameter to the query
                    cmd.Parameters.AddWithValue("@notificationId", notificationId);
                    // Execute the query to delete the notification
                    cmd.ExecuteNonQuery();
                }
            }
        }
        // Retrieve customer id through given email
        public static int RetrieveCustomerId(string email)
        {
            int customerId = 0;
            // Open MySQL connection
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                // SQL query to select the customer id associated to the given email
                string query = "SELECT customer_id FROM customer_information WHERE email = @Email";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Add parameter to the query
                    cmd.Parameters.AddWithValue("@Email", email);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            customerId = reader.GetInt32(0);
                        }
                    }
                }
            }

            return customerId;
        }
        // Set the last activity date to date today
        public static void UpdateLastActivityDate(string email)
        {
            // Open MySQL connection
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                // SQL query to update the last activity date to the date today.
                string query = "UPDATE account " +
                               "JOIN customer_information ON account.customer_id = customer_information.customer_id " +
                               "SET account.last_activity_date = CURDATE() " +
                               "WHERE customer_information.email = @email";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Add parameters to the query
                    cmd.Parameters.AddWithValue("@email", email);
                    // Execute the query to update the last activity date
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
