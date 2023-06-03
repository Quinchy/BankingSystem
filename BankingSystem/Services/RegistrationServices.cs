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
            // Open connection using MySQLDatabase.OpenConnection()
            using (var connection = BankingSystem.Database.MySQLDatabase.OpenConnection())
            {
                if (connection != null)
                {
                    // Write an SQL statement to insert the customer into the database
                    string query = "INSERT INTO customer (first_name, last_name, email, phone_number, password) VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @Password); SELECT LAST_INSERT_ID();";
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
                        // Generate account ID
                        string accountId = generateAccountId(customer.FirstName, customer.LastName, customer.PhoneNumber);
                        // Insert a new row into the Account table
                        query = "INSERT INTO account (account_id, balance, customer_id) VALUES (@AccountId, @Balance, @CustomerId)";
                        using (var accountCommand = new MySqlCommand(query, connection))
                        {
                            accountCommand.Parameters.AddWithValue("@AccountId", accountId);
                            accountCommand.Parameters.AddWithValue("@Balance", 0.0); // Assuming that the initial balance is 0
                            accountCommand.Parameters.AddWithValue("@CustomerId", customerId);

                            // Execute the query
                            accountCommand.ExecuteNonQuery();
                        }
                    }
                    // Close connection using MySQLDatabase.CloseConnection()
                    BankingSystem.Database.MySQLDatabase.CloseConnection(connection);
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