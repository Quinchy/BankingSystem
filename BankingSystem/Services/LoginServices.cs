using BankingSystem.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Services
{
    internal class LoginServices
    {
        public static int authenticateUser(String email, String password)
        {
            // Open connection
            using (var connection = new MySqlConnection("server=localhost;userid=root;password=;database=banking_system"))
            {
                connection.Open();
                // Write an SQL statement to check if the user is in the database
                string query = $"SELECT COUNT(*) FROM customer WHERE email = @Email";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    // Execute the query and get the result
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count == 0) return -1; // Email does not exist

                    query = $"SELECT COUNT(*) FROM customer WHERE email = @Email AND password = @Password";
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@Password", password);
                    count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0 ? 1 : 0; // If count > 0, password is correct, otherwise incorrect
                }
            }
        }
    }
}