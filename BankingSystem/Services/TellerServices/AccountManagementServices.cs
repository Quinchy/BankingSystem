using BankingSystem.Models;
using BankingSystem.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Services.TellerServices
{
    internal class AccountManagementServices
    {
        public static void loadAccountRequest(ListView accountManagementListView)
        {
            // Open connection using MySQLDatabase.OpenConnection()
            using (var connection = MySQLDatabase.OpenConnection())
            {
                if (connection != null)
                {
                    // Write an SQL statement to join account_request and customer_information tables
                    string query = @"SELECT account_request.request_id, 
                    account_request.customer_id, 
                    customer_information.email,
                    account_request.request_date,
                    account_request.request_status
                    FROM account_request
                    INNER JOIN customer_information 
                    ON account_request.customer_id = customer_information.customer_id
                    WHERE account_request.request_status = 'Pending'";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        // Execute the query and get the result set
                        using (var reader = command.ExecuteReader())
                        {
                            // Clear existing items
                            accountManagementListView.Items.Clear();

                            // Loop through the result set
                            while (reader.Read())
                            {
                                // Get the request ID, customer ID, email, date of request and request status
                                var requestId = reader["request_id"].ToString();
                                var customerId = reader["customer_id"].ToString();
                                var email = reader["email"].ToString();
                                // Format the date to exclude the time part
                                var dateOfRequest = Convert.ToDateTime(reader["request_date"]).ToString("yyyy-MM-dd");
                                var requestStatus = reader["request_status"].ToString();

                                // Create a new list view item
                                var item = new ListViewItem(new[] { requestId, customerId, email, dateOfRequest, requestStatus });

                                // Add the item to the list view
                                accountManagementListView.Items.Add(item);
                            }
                        }
                    }
                    // Close connection using MySQLDatabase.CloseConnection()
                    MySQLDatabase.CloseConnection(connection);
                }
            }
        }
        public static void loadAccountList(ListView accountListView)
        {
            // Open connection using MySQLDatabase.OpenConnection()
            using (var connection = MySQLDatabase.OpenConnection())
            {
                if (connection != null)
                {
                    // Write an SQL statement to get all accounts
                    string query = "SELECT account_id, customer_id, balance, account_status FROM account";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        // Execute the query and get the result set
                        using (var reader = command.ExecuteReader())
                        {
                            // Clear existing items
                            accountListView.Items.Clear();

                            // Loop through the result set
                            while (reader.Read())
                            {
                                // Get the account ID, customer ID, balance and account status
                                var accountId = reader["account_id"].ToString();
                                var customerId = reader["customer_id"].ToString();
                                var balance = reader["balance"].ToString();
                                var accountStatus = reader["account_status"].ToString();

                                // Create a new list view item
                                var item = new ListViewItem(new[] { accountId, customerId, balance, accountStatus });

                                // Add the item to the list view
                                accountListView.Items.Add(item);
                            }
                        }
                    }
                    // Close connection using MySQLDatabase.CloseConnection()
                    MySQLDatabase.CloseConnection(connection);
                }
            }
        }
        public static void approveAccount(int requestId)
        {
            // Open connection using MySQLDatabase.OpenConnection()
            using (var connection = MySQLDatabase.OpenConnection())
            {
                if (connection != null)
                {
                    // Retrieve the customer ID from the account_request table
                    string query = "SELECT customer_id FROM account_request WHERE request_id = @RequestId";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RequestId", requestId);

                        // Execute the query and get the customer ID
                        var customerId = command.ExecuteScalar();

                        // Fetch the customer's details using customerId
                        query = "SELECT first_name, last_name, phone_number FROM customer_information WHERE customer_id = @CustomerId";
                        using (var customerCommand = new MySqlCommand(query, connection))
                        {
                            customerCommand.Parameters.AddWithValue("@CustomerId", customerId);

                            // Variables for storing the customer's details
                            string firstName = null;
                            string lastName = null;
                            string phoneNumber = null;

                            // Execute the query and get the customer's details
                            using (var reader = customerCommand.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    firstName = reader["first_name"].ToString();
                                    lastName = reader["last_name"].ToString();
                                    phoneNumber = reader["phone_number"].ToString();
                                }
                            }
                            // Generate account ID
                            string accountId = generateAccountId(firstName, lastName, phoneNumber);
                            // Insert a new row into the Account table
                            query = "INSERT INTO account (account_id, customer_id, balance, account_status) VALUES (@AccountId, @CustomerId, @Balance, @AccountStatus)";
                            using (var accountCommand = new MySqlCommand(query, connection))
                            {
                                accountCommand.Parameters.AddWithValue("@AccountId", accountId);
                                accountCommand.Parameters.AddWithValue("@Balance", 0.0); // Assuming that the initial balance is 0
                                accountCommand.Parameters.AddWithValue("@CustomerId", customerId);
                                accountCommand.Parameters.AddWithValue("@AccountStatus", "Open");

                                // Execute the query
                                accountCommand.ExecuteNonQuery();
                            }
                            // Update the request_status in the account_request table
                            query = "UPDATE account_request SET request_status = 'Approved' WHERE request_id = @RequestId";
                            using (var updateCommand = new MySqlCommand(query, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@RequestId", requestId);

                                // Execute the query
                                updateCommand.ExecuteNonQuery();
                            }
                        }
                    }
                    // Close connection using MySQLDatabase.CloseConnection()
                    MySQLDatabase.CloseConnection(connection);
                }
            }
        }
        public static void rejectAccount(int requestId)
        {
            // Open connection using MySQLDatabase.OpenConnection()
            using (var connection = MySQLDatabase.OpenConnection())
            {
                if (connection != null)
                {
                    // Update the request_status in the account_request table
                    string query = "UPDATE account_request SET request_status = 'Rejected' WHERE request_id = @RequestId";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RequestId", requestId);

                        // Execute the query
                        command.ExecuteNonQuery();
                    }
                    // Close connection using MySQLDatabase.CloseConnection()
                    MySQLDatabase.CloseConnection(connection);
                }
            }
        }
        public static void openAnAccount(int accountId)
        {
            // Open connection using MySQLDatabase.OpenConnection()
            using (var connection = MySQLDatabase.OpenConnection())
            {
                if (connection != null)
                {
                    // Update the account_status in the account table
                    string query = "UPDATE account SET account_status = 'Open' WHERE account_id = @AccountId";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AccountId", accountId);

                        // Execute the query
                        command.ExecuteNonQuery();
                    }
                    // Close connection using MySQLDatabase.CloseConnection()
                    MySQLDatabase.CloseConnection(connection);
                }
            }
        }
        public static void closeAnAccount(int accountId)
        {
            // Open connection using MySQLDatabase.OpenConnection()
            using (var connection = MySQLDatabase.OpenConnection())
            {
                if (connection != null)
                {
                    // Update the account_status in the account table
                    string query = "UPDATE account SET account_status = 'Closed' WHERE account_id = @AccountId";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AccountId", accountId);

                        // Execute the query
                        command.ExecuteNonQuery();
                    }
                    // Close connection using MySQLDatabase.CloseConnection()
                    MySQLDatabase.CloseConnection(connection);
                }
            }
        }
        public static string generateAccountId(string firstName, string lastName, string phoneNumber)
        {
            // Get the first two characters of the first name
            string firstPart = firstName.Substring(0, 2).ToUpper();
            // Get the last two characters of the last name
            string secondPart = lastName.Substring(lastName.Length - 2, 2).ToUpper();
            // Get the last four characters of the phone number
            string thirdPart = phoneNumber.Substring(phoneNumber.Length - 4, 4);
            // Concatenate the parts to form the account ID
            string accountId = firstPart + secondPart + thirdPart;
            return accountId;
        }
    }
}
