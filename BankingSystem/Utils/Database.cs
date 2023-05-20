using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Utils
{
    internal class Database
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Database()
        {
            server = "localhost"; // MySQL server address
            database = "banking_system"; // Database name
            uid = "root"; // MySQL username
            password = ""; // MySQL password

            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                // Handle the exception (display error message, log, etc.)
                Console.WriteLine(ex);
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                // Handle the exception (display error message, log, etc.)
                Console.WriteLine(ex);
                return false;
            }
        }

        // Additional methods for executing queries, inserts, updates, etc.
        // ...
    }
}
