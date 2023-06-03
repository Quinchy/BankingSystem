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
            int customerId;
            string firstName, lastName, emailAddress, phoneNumber, password, accountId = "";
            double balance = 0;
            // Open connection using MySQLDatabase.OpenConnection()
            using (var connection = BankingSystem.Database.MySQLDatabase.OpenConnection())
            {
                if (connection != null)
                {
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
                    // Create a new Account object with the retrieved data
                    currentAccount = new Account(accountId, balance);
                }
            }
            return Tuple.Create(currentCustomer, currentAccount);
        }
    }
}
