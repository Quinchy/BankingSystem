﻿using BankingSystem.Models;
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
    internal class AccountManagementServices
    {
        public static List<AccountRequest> loadAccountRequest()
        {
            var accountRequests = new List<AccountRequest>();
            using (var connection = MySQLDatabase.OpenConnection())
            {
                if (connection != null)
                {
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
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var requestId = reader["request_id"].ToString();
                                var customerId = reader["customer_id"].ToString();
                                var email = reader["email"].ToString();
                                var dateOfRequest = Convert.ToDateTime(reader["request_date"]);
                                var requestStatus = reader["request_status"].ToString();

                                accountRequests.Add(new AccountRequest(requestId, customerId, email, dateOfRequest, requestStatus));
                            }
                        }
                    }
                }
            }
            return accountRequests;
        }
        public static List<Account> loadAccountList()
        {
            var accounts = new List<Account>();
            using (var connection = MySQLDatabase.OpenConnection())
            {
                if (connection != null)
                {
                    string query = "SELECT account_id, customer_id, balance, account_status FROM account";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var accountId = reader["account_id"].ToString();
                                var customerId = reader["customer_id"].ToString();
                                var balance = Convert.ToDouble(reader["balance"]);
                                var accountStatus = reader["account_status"].ToString();

                                accounts.Add(new Account(accountId, customerId, balance, accountStatus));
                            }
                        }
                    }
                }
            }
            return accounts;
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
                    // Close connection using MySQLDatabase.CloseConnection()
                    MySQLDatabase.CloseConnection(connection);
                }
            }
        }
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