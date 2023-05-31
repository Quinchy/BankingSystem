using BankingSystem.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Services
{
    internal class RegistrationServices
    {
        public static void registerUser(Customer customer)
        {
            // Open connection
            using (var connection = new MySqlConnection("server=localhost;userid=root;password=;database=banking_system"))
            {
                connection.Open();
                // Write an SQL statement to insert the customer into the database
                string query = "INSERT INTO customer (first_name, last_name, email, phone_number, password) VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @Password)";
                using (var command = new MySqlCommand(query, connection))
                {
                    // Use parameterized query to prevent SQL injection
                    command.Parameters.AddWithValue("@FirstName", customer.FirstName);
                    command.Parameters.AddWithValue("@LastName", customer.LastName);
                    command.Parameters.AddWithValue("@Email", customer.Email);
                    command.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
                    command.Parameters.AddWithValue("@Password", customer.Password);
                    // Execute the query
                    command.ExecuteNonQuery();
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