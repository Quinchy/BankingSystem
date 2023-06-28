using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Database
{
    // A class for managing MySQL database connections
    internal class MySQLDatabase
    {
        private static string server;
        private static string database;
        private static string uid;
        private static string password;
        static MySQLDatabase()
        {
            Initialize();
        }
        // Initialize the database connection settings
        private static void Initialize()
        {
            server = "localhost";
            database = "banking_system";
            uid = "root"; // Default XAMPP MySQL username
            password = ""; // Default XAMPP MySQL password
        }
        // Open a connection to the MySQL database
        public static MySqlConnection OpenConnection()
        {
            try
            {
                string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password}";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (MySqlException ex)
            {
                // Output the exception details for debugging
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        // Method to enable event scheduler
        public static void EnableEventScheduler()
        {
            using (MySqlConnection connection = OpenConnection())
            {
                if (connection != null)
                {
                    try
                    {
                        MySqlCommand command = new MySqlCommand("SET GLOBAL event_scheduler = ON", connection);
                        command.ExecuteNonQuery();
                        Console.WriteLine("Event scheduler enabled.");
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine("Error enabling event scheduler: " + ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Failed to establish a database connection.");
                }
            }
        }
    }
}