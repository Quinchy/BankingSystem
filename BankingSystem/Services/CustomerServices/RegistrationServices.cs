using BankingSystem.Models.CustomerModels;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Services.CustomerServices
{
    internal class RegistrationServices
    {
        // Registers a new user in the system
        public static void registerUser(Customer customer)
        {
            // Open a connection to the database
            using (var connection = Database.MySQLDatabase.OpenConnection())
            {
                if (connection != null)
                {
                    // Insert the new user's information into the customer_information table
                    string query = "INSERT INTO customer_information (first_name, last_name, email, phone_number, password) VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @Password); SELECT LAST_INSERT_ID();";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        // Add the user's information to the query
                        command.Parameters.AddWithValue("@FirstName", customer.FirstName);
                        command.Parameters.AddWithValue("@LastName", customer.LastName);
                        command.Parameters.AddWithValue("@Email", customer.Email);
                        command.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
                        command.Parameters.AddWithValue("@Password", customer.Password);
                        // Execute the query and get the ID of the new user
                        var customerId = command.ExecuteScalar();
                        // Insert a new account request for the user into the account_request table
                        query = "INSERT INTO account_request (customer_id, request_date, request_status) VALUES (@CustomerId, @RequestDate, @RequestStatus)";
                        using (var requestCommand = new MySqlCommand(query, connection))
                        {
                            // Add the new user's ID, the current date and time, and the initial request status to the query
                            requestCommand.Parameters.AddWithValue("@CustomerId", customerId);
                            requestCommand.Parameters.AddWithValue("@RequestDate", DateTime.Now);
                            requestCommand.Parameters.AddWithValue("@RequestStatus", "Pending");
                            // Execute the query
                            requestCommand.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
        // Checks if the password and the confirmation password match
        public static bool IsPasswordMatch(string password, string confirmPassword)
        {
            return password == confirmPassword;
        }
        // Checks if the user's information is valid
        public static bool IsValidCustomer(Customer customer)
        {
            if (string.IsNullOrEmpty(customer.FirstName) || string.IsNullOrEmpty(customer.LastName) ||
                string.IsNullOrEmpty(customer.Email) || string.IsNullOrEmpty(customer.PhoneNumber) ||
                string.IsNullOrEmpty(customer.Password))
            {
                // If any of the fields are null or empty, return false
                return false;
            }
            // If all fields contain data, return true
            return true;
        }
    }
}