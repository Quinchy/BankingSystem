using BankingSystem.Models.CustomerModels;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Services.CustomerServices
{
    // This class contains all the methods used by CustomerProfileForm.
    internal class CustomerProfileServices
    {
        // Retrieves all customer information from the database using the customer's email.
        public static Customer retrieveCustomerInformation(string email)
        {
            Customer currentCustomer = null;
            string firstName, lastName, emailAddress, phoneNumber, password, accountId;
            // Open MySQL connection
            using (var connection = Database.MySQLDatabase.OpenConnection())
            {
                // SQL query to fetch customer information and account id from the database.
                string query = @"
                    SELECT c.first_name, c.last_name, c.email, c.phone_number, c.password, a.account_id 
                    FROM customer_information c
                    LEFT JOIN account a ON c.customer_id = a.customer_id 
                    WHERE c.email = @Email";
                using (var command = new MySqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@Email", email);
                    // Execute the query and store the result.
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve the customer information and account id from the result.
                            accountId = reader["account_id"].ToString();
                            firstName = reader["first_name"].ToString();
                            lastName = reader["last_name"].ToString();
                            emailAddress = reader["email"].ToString();
                            phoneNumber = reader["phone_number"].ToString();
                            password = reader["password"].ToString();
                            // Create a new Customer object with the retrieved information.
                            currentCustomer = new Customer(accountId, firstName, lastName, emailAddress, phoneNumber, password);
                        }
                    }
                }
            }
            // Return the Customer object.
            return currentCustomer;
        }
    }
}
