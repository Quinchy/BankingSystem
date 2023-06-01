using BankingSystem.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Services
{
    internal class CustomerServices
    {
        public static Tuple<Customer, Account> loadCustomerInformation(string email)
        {
            Customer currentCustomer = null;
            Account currentAccount = null;
            int customerId = 0;
            string firstName = "", lastName = "", emailAddress = "", phoneNumber = "", password = "", accountId = "";
            double balance = 0;

            // Open connection
            using (var connection = new MySqlConnection("server=localhost;userid=root;password=;database=banking_system"))
            {
                connection.Open();
                // Write an SQL statement to retrieve the customer and account information from the database
                string query = @"
                    SELECT c.customer_id, c.first_name, c.last_name, c.email, c.phone_number, c.password, a.account_id, a.balance 
                    FROM customer c
                    LEFT JOIN account a ON c.customer_id = a.customer_id 
                    WHERE c.email = @Email";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    using (var reader = command.ExecuteReader())
                    {
                        // Check if any results were returned
                        if (reader.Read())
                        {
                            // Get the data from the result
                            customerId = Convert.ToInt32(reader["customer_id"]);
                            firstName = reader["first_name"].ToString();
                            lastName = reader["last_name"].ToString();
                            emailAddress = reader["email"].ToString();
                            phoneNumber = reader["phone_number"].ToString();
                            password = reader["password"].ToString();
                            accountId = reader["account_id"].ToString();
                            balance = accountId != "" ? Convert.ToDouble(reader["balance"]) : 0;
                            // Create a new Customer object with the retrieved data
                            currentCustomer = new Customer(firstName, lastName, emailAddress, phoneNumber, password);
                        }
                    }
                }
                // If account_id is null or empty, generate a new account ID, add it to the database, and then retrieve it
                if (string.IsNullOrEmpty(accountId))
                {
                    accountId = generateAccountId(firstName, lastName, phoneNumber);
                    // Now, insert the new account ID into the database
                    using (var insertionCommand = new MySqlCommand("INSERT INTO account (account_id, customer_id, balance) VALUES (@AccountId, @CustomerId, @Balance)", connection))
                    {
                        insertionCommand.Parameters.AddWithValue("@AccountId", accountId);
                        insertionCommand.Parameters.AddWithValue("@CustomerId", customerId);
                        insertionCommand.Parameters.AddWithValue("@Balance", 0);
                        insertionCommand.ExecuteNonQuery();
                    }
                    // Set the initial balance to 0
                    balance = 0;
                }
                // Create a new Account object with the retrieved data
                currentAccount = new Account(accountId, balance);
            }
            return Tuple.Create(currentCustomer, currentAccount);
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
