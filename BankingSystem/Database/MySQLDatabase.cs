using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Database
{
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
        private static void Initialize()
        {
            server = "localhost";
            database = "banking_system";
            uid = "root"; //default XAMPP MySQL username
            password = ""; //default XAMPP MySQL password
        }
        public static MySqlConnection OpenConnection()
        {
            try
            {
                string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (MySqlException ex)
            {
                //Output the exception details for debugging
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static bool CloseConnection(MySqlConnection connection)
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                //Output the exception details for debugging
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}