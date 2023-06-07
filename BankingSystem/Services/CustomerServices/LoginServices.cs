using BankingSystem.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Services.CustomerServices
{
    internal class LoginServices
    {
        public static int authenticateUser(string email, string password)
        {
            // Open connection using MySQLDatabase.OpenConnection()
            using (var connection = Database.MySQLDatabase.OpenConnection())
            {
                if (connection != null)
                {
                    // Write an SQL statement to check if the user is in the database
                    string query = $"SELECT COUNT(*) FROM customer_information WHERE email = @Email";
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
                        query = $"SELECT COUNT(*) FROM customer_information WHERE email = @Email AND password = @Password";
                        command.CommandText = query;
                        command.Parameters.AddWithValue("@Password", password);
                        count = Convert.ToInt32(command.ExecuteScalar());
                        if (count == 0)
                        {
                            // Password is incorrect
                            return -2;
                        }
                        // Check if the account is open or closed
                        query = $"SELECT account_status FROM account INNER JOIN customer_information ON account.customer_id = customer_information.customer_id WHERE email = @Email";
                        command.CommandText = query;
                        string status = Convert.ToString(command.ExecuteScalar());
                        if (status == "Close")
                        {
                            // Account is closed
                            return -3;
                        }
                        // Check if there is a pending account request
                        query = $"SELECT request_status FROM account_request INNER JOIN customer_information ON account_request.customer_id = customer_information.customer_id WHERE email = @Email";
                        command.CommandText = query;
                        string requestStatus = Convert.ToString(command.ExecuteScalar());
                        if (requestStatus == "Pending")
                        {
                            // Account request is pending
                            return -4;
                        }
                        else if (requestStatus == "Rejected")
                        {
                            // Account request is rejected
                            return -5;
                        }
                        // If count > 0, password is correct, account is open, and no pending or rejected account request, otherwise incorrect
                        return 1;
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