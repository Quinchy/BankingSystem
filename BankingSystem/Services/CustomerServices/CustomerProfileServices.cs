using BankingSystem.Models.CustomerModels;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Services.CustomerServices
{
    internal class CustomerProfileServices
    {
        // This method retrieves customer information from the database using the customer's email.
        public static Customer retrieveCustomerInformation(string email)
        {
            Customer currentCustomer = null;
            string firstName, lastName, emailAddress, phoneNumber, password, accountId;
            // Open a connection to the database.
            using (var connection = Database.MySQLDatabase.OpenConnection())
            {
                // Check if the connection is successful.
                if (connection != null)
                {
                    // SQL query to fetch customer information and account id from the database.
                    string query = @"
                        SELECT c.first_name, c.last_name, c.email, c.phone_number, c.password, a.account_id 
                        FROM customer_information c
                        LEFT JOIN account a ON c.customer_id = a.customer_id 
                        WHERE c.email = @Email";
                    // Execute the SQL query.
                    using (var command = new MySqlCommand(query, connection))
                    {
                        // Add the email parameter to the SQL query to prevent SQL injection.
                        command.Parameters.AddWithValue("@Email", email);
                        // Execute the query and store the result.
                        using (var reader = command.ExecuteReader())
                        {
                            // Check if the query returned a result.
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
            }
            // Return the Customer object. If no customer was found, this will be null.
            return currentCustomer;
        }
    }
}
