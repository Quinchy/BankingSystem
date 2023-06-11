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
        public static void registerUser(Customer customer)
        {
            // Open connection using MySQLDatabase.OpenConnection()
            using (var connection = Database.MySQLDatabase.OpenConnection())
            {
                if (connection != null)
                {
                    // Write an SQL statement to insert the customer into the database
                    string query = "INSERT INTO customer_information (first_name, last_name, email, phone_number, password) VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @Password); SELECT LAST_INSERT_ID();";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        // Use parameterized query to prevent SQL injection
                        command.Parameters.AddWithValue("@FirstName", customer.FirstName);
                        command.Parameters.AddWithValue("@LastName", customer.LastName);
                        command.Parameters.AddWithValue("@Email", customer.Email);
                        command.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
                        command.Parameters.AddWithValue("@Password", customer.Password);

                        // Execute the query and get the ID of the last inserted customer
                        var customerId = command.ExecuteScalar();

                        // Insert a new row into the account_request table
                        query = "INSERT INTO account_request (customer_id, request_date, request_status) VALUES (@CustomerId, @RequestDate, @RequestStatus)";
                        using (var requestCommand = new MySqlCommand(query, connection))
                        {
                            requestCommand.Parameters.AddWithValue("@CustomerId", customerId);
                            // Add the current date and time
                            requestCommand.Parameters.AddWithValue("@RequestDate", DateTime.Now);
                            // Set the request status to 'Pending'
                            requestCommand.Parameters.AddWithValue("@RequestStatus", "Pending");

                            // Execute the query
                            requestCommand.ExecuteNonQuery();
                        }
                    }
                    // Close connection using MySQLDatabase.CloseConnection()
                    Database.MySQLDatabase.CloseConnection(connection);
                }
            }
        }
        public static bool IsPasswordMatch(string password, string confirmPassword)
        {
            return password == confirmPassword;
        }
        public static bool IsValidCustomer(Customer customer)
        {
            if (string.IsNullOrEmpty(customer.FirstName) || string.IsNullOrEmpty(customer.LastName) ||
                string.IsNullOrEmpty(customer.Email) || string.IsNullOrEmpty(customer.PhoneNumber) ||
                string.IsNullOrEmpty(customer.Password))
            {
                return false;
            }
            return true;
        }
    }
}