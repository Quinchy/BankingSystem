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
            // Open connection using MySQLDatabase.OpenConnection()
            using (var connection = BankingSystem.Database.MySQLDatabase.OpenConnection())
            {
                if (connection != null)
                {
                    // Write an SQL statement to check if the user is in the database
                    string query = $"SELECT COUNT(*) FROM customer WHERE email = @Email";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        // Execute the query and get the result
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        if (count == 0)
                        {
                            // Email does not exist
                            return -1;
                        }
                        query = $"SELECT COUNT(*) FROM customer WHERE email = @Email AND password = @Password";
                        command.CommandText = query;
                        command.Parameters.AddWithValue("@Password", password);
                        count = Convert.ToInt32(command.ExecuteScalar());
                        // If count > 0, password is correct, otherwise incorrect
                        return count > 0 ? 1 : 0;
                    }
                }
                else
                {
                    // Connection failed
                    return -1;
                }
            }
        }
    }
}