using BankingSystem.Models;
using BankingSystem.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingSystem.Models.TellerModels;

namespace BankingSystem.Services.TellerServices
{
    // A service class for managing account request and also managing the closing and opening of an account.
    internal class AccountManagementServices
    {
        public static List<AccountRequest> RetrieveAccountRequests(int limit = 6, int offset = 0)
        {
            List<AccountRequest> requests = new List<AccountRequest>();
            // Open a connection to the MySQL database
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                // SQL query to retrieve account requests
                string sql = @"
                    SELECT ar.request_id, ci.first_name, ci.last_name, ci.email, ci.phone_number, ci.password, ar.request_date, ar.request_status
                    FROM account_request ar
                    JOIN customer_information ci ON ar.customer_id = ci.customer_id
                    WHERE ar.request_status = 'Pending'
                    ORDER BY ar.request_date DESC
                    LIMIT @Limit
                    OFFSET @Offset";
                MySqlCommand command = new MySqlCommand(sql, connection);
                // Use the limit and offset parameters in the SQL query
                command.Parameters.AddWithValue("@Limit", limit);
                command.Parameters.AddWithValue("@Offset", offset);
                // Execute the command and process the results
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AccountRequest request = new AccountRequest(
                            reader.GetString("request_id"),
                            reader.GetString("first_name"),
                            reader.GetString("last_name"),
                            reader.GetString("email"),
                            reader.GetString("phone_number"),
                            reader.GetString("password"),
                            reader.GetDateTime("request_date"),
                            reader.GetString("request_status")
                        );
                        requests.Add(request);
                    }
                }
            }
            return requests;
        }
        // Loads a list of accounts from the database
        public static List<AccountList> RetrieveAccountLists(int limit = 6, int offset = 0)
        {
            List<AccountList> accountLists = new List<AccountList>();

            // Open a connection to the MySQL database
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                // SQL query to retrieve account requests
                string sql = @"
                    SELECT a.account_id, ci.first_name, ci.last_name, ci.email, ci.phone_number, ci.password, a.balance, a.account_status
                    FROM account a
                    JOIN customer_information ci ON a.customer_id = ci.customer_id
                    ORDER BY a.account_id DESC
                    LIMIT @Limit
                    OFFSET @Offset";
                MySqlCommand command = new MySqlCommand(sql, connection);
                // Use the limit and offset parameters in the SQL query
                command.Parameters.AddWithValue("@Limit", limit);
                command.Parameters.AddWithValue("@Offset", offset);

                // Execute the command and process the results
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AccountList account = new AccountList(
                            reader.GetString("account_id"),
                            reader.GetString("first_name"),
                            reader.GetString("last_name"),
                            reader.GetString("email"),
                            reader.GetString("phone_number"),
                            reader.GetString("password"),
                            reader.GetDouble("balance"),
                            reader.GetString("account_status")
                        );
                        accountLists.Add(account);
                    }
                }
            }
            return accountLists;
        }
        public static int RetrieveTotalAccountRequests()
        {
            int totalRequests = 0;
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                string sql = "SELECT COUNT(*) FROM account_request WHERE request_status = 'Pending'";
                MySqlCommand command = new MySqlCommand(sql, connection);
                totalRequests = Convert.ToInt32(command.ExecuteScalar());
            }
            return totalRequests;
        }

        public static int RetrieveTotalAccountLists()
        {
            int totalAccounts = 0;
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                string sql = "SELECT COUNT(*) FROM account";
                MySqlCommand command = new MySqlCommand(sql, connection);
                totalAccounts = Convert.ToInt32(command.ExecuteScalar());
            }
            return totalAccounts;
        }
        // Approve a request for an account.
        public static void ApproveAccount(string requestId)
        {
            using (var connection = BankingSystem.Database.MySQLDatabase.OpenConnection())
            {
                if (connection != null)
                {
                    string query = "SELECT customer_id FROM account_request WHERE request_id = @RequestId";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RequestId", requestId);
                        var customerId = command.ExecuteScalar();

                        query = "SELECT first_name, last_name, phone_number FROM customer_information WHERE customer_id = @CustomerId";
                        using (var customerCommand = new MySqlCommand(query, connection))
                        {
                            customerCommand.Parameters.AddWithValue("@CustomerId", customerId);
                            string firstName = null;
                            string lastName = null;
                            string phoneNumber = null;

                            using (var reader = customerCommand.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    firstName = reader["first_name"].ToString();
                                    lastName = reader["last_name"].ToString();
                                    phoneNumber = reader["phone_number"].ToString();
                                }
                            }

                            string accountId = GenerateAccountId(firstName, lastName, phoneNumber);
                            query = "INSERT INTO account (account_id, customer_id, balance, account_status) VALUES (@AccountId, @CustomerId, @Balance, @AccountStatus)";

                            using (var accountCommand = new MySqlCommand(query, connection))
                            {
                                accountCommand.Parameters.AddWithValue("@AccountId", accountId);
                                accountCommand.Parameters.AddWithValue("@CustomerId", customerId);
                                accountCommand.Parameters.AddWithValue("@Balance", 0.0);
                                accountCommand.Parameters.AddWithValue("@AccountStatus", "Open");
                                accountCommand.ExecuteNonQuery();
                            }

                            query = "UPDATE account_request SET request_status = 'Approved' WHERE request_id = @RequestId";

                            using (var updateCommand = new MySqlCommand(query, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@RequestId", requestId);
                                updateCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }

        // Reject the request for an account.
        public static void RejectAccount(string requestId)
        {
            using (var connection = BankingSystem.Database.MySQLDatabase.OpenConnection())
            {
                if (connection != null)
                {
                    string query = "UPDATE account_request SET request_status = 'Rejected' WHERE request_id = @RequestId";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RequestId", requestId);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        // Generate an account id for new customer
        public static string GenerateAccountId(string firstName, string lastName, string phoneNumber)
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
        // Open the account for the customer.
        public static void openAnAccount(string accountId)
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
                }
            }
        }
        // Close the account of a customer
        public static void closeAnAccount(string accountId)
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
                }
            }
        }
    }
}
