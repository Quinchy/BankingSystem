using BankingSystem.Models.CustomerModels;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BankingSystem.Services.CustomerServices
{
    // This class contains all methods used by RegistrationForm
    internal class RegistrationServices
    {
        // Regex pattern for valid email address
        private static readonly string EmailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        // Regex pattern for PH phone number (starts with 09 and followed by 9 digits)
        private static readonly string PhoneNumberPattern = @"^09\d{9}$";
        // Registers a new user in the system
        public static void registerUser(Customer customer)
        {
            // Open MySQL connection
            using (var connection = Database.MySQLDatabase.OpenConnection())
            {
                if (connection != null)
                {
                    // Insert the new user's information into the customer_information table
                    string query = "INSERT INTO customer_information (first_name, last_name, email, phone_number, password) VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @Password); SELECT LAST_INSERT_ID();";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        // Add parameters to the query
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
                            // Add parameters to the query
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
        // Method to check if an email is valid
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email)) return false;

            return Regex.IsMatch(email, EmailPattern, RegexOptions.IgnoreCase);
        }

        // Method to check if a phone number is valid
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber)) return false;

            return Regex.IsMatch(phoneNumber, PhoneNumberPattern);
        }

        // Method to correct name format (capitalize first letter of each word, trim spaces)
        public static string CorrectNameFormat(string name)
        {
            if (string.IsNullOrEmpty(name)) return null;

            // Ensure the name contains only letters and spaces
            if (!name.All(c => char.IsLetter(c) || char.IsWhiteSpace(c))) return null;

            // Capitalize first letter of each word, make rest lowercase
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(name.ToLower());
        }
    }
}