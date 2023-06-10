using BankingSystem.Models;
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
        public static Customer retrieveCustomerInformation(string email)
        {
            Customer currentCustomer = null;
            string firstName, lastName, emailAddress, phoneNumber, password, accountId;
            using (var connection = Database.MySQLDatabase.OpenConnection())
            {
                if (connection != null)
                {
                    string query = @"
                        SELECT c.first_name, c.last_name, c.email, c.phone_number, c.password, a.account_id 
                        FROM customer_information c
                        LEFT JOIN account a ON c.customer_id = a.customer_id 
                        WHERE c.email = @Email";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                accountId = reader["account_id"].ToString();
                                firstName = reader["first_name"].ToString();
                                lastName = reader["last_name"].ToString();
                                emailAddress = reader["email"].ToString();
                                phoneNumber = reader["phone_number"].ToString();
                                password = reader["password"].ToString();
                                currentCustomer = new Customer(accountId, firstName, lastName, emailAddress, phoneNumber, password);
                            }
                        }
                    }
                }
            }
            return currentCustomer;
        }
    }
}
