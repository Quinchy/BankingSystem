using BankingSystem.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Services.CustomerServices
{
    internal class CustomerUpdateServices
    {
        // Method to request an email update
        public static void requestEmailUpdate(string accountId, string newEmail)
        {
            using (MySqlConnection conn = MySQLDatabase.OpenConnection())
            {
                // Check if there's a pending request in the database
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM customer_update WHERE account_id = @accountId AND update_status = 'Pending'", conn);
                cmd.Parameters.AddWithValue("@accountId", accountId);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    // Alert the user that they have a pending request
                    throw new Exception("You have a pending request. Please wait for it to be processed before sending a new request.");
                }
                reader.Close();
                // Check if the new email is already associated with any account
                cmd = new MySqlCommand("SELECT * FROM customer_information WHERE email = @newEmail", conn);
                cmd.Parameters.AddWithValue("@newEmail", newEmail);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    throw new Exception("The new email is already linked to an account. Please use a different email.");
                }
                reader.Close();
                // Insert the new email update request into the customer_update table
                cmd = new MySqlCommand("INSERT INTO customer_update (account_id, information_type, changed_information, update_status) VALUES (@accountId, 'Email', @newEmail, 'Pending')", conn);
                cmd.Parameters.AddWithValue("@accountId", accountId);
                cmd.Parameters.AddWithValue("@newEmail", newEmail);
                cmd.ExecuteNonQuery();
            }
        }
        // Method to request a phone number update
        public static void requestPhoneNumberUpdate(string accountId, string newPhoneNumber)
        {
            using (MySqlConnection conn = MySQLDatabase.OpenConnection())
            {
                // Check if there's a pending request in the database
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM customer_update WHERE account_id = @accountId AND update_status = 'Pending'", conn);
                cmd.Parameters.AddWithValue("@accountId", accountId);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    // Alert the user that they have a pending request
                    throw new Exception("You have a pending request. Please wait for it to be processed before sending a new request.");
                }
                reader.Close();
                // Check if the new phone number is already associated with any account
                cmd = new MySqlCommand("SELECT * FROM customer_information WHERE phone_number = @newPhoneNumber", conn);
                cmd.Parameters.AddWithValue("@newPhoneNumber", newPhoneNumber);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    throw new Exception("The new phone number is already linked to an account. Please use a different phone number.");
                }
                reader.Close();
                // Insert the new phone number update request into the customer_update table
                cmd = new MySqlCommand("INSERT INTO customer_update (account_id, information_type, changed_information, update_status) VALUES (@accountId, 'Phone Number', @newPhoneNumber, 'Pending')", conn);
                cmd.Parameters.AddWithValue("@accountId", accountId);
                cmd.Parameters.AddWithValue("@newPhoneNumber", newPhoneNumber);
                cmd.ExecuteNonQuery();
            }
        }
        // Method to request a password update
        public static void requestPasswordUpdate(string accountId, string newPassword)
        {
            using (MySqlConnection conn = MySQLDatabase.OpenConnection())
            {
                // Check if there's a pending request in the database
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM customer_update WHERE account_id = @accountId AND update_status = 'Pending'", conn);
                cmd.Parameters.AddWithValue("@accountId", accountId);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    // Alert the user that they have a pending request
                    throw new Exception("You have a pending request. Please wait for it to be processed before sending a new request.");
                }
                reader.Close();
                // Check if the new password is the same as the current one
                cmd = new MySqlCommand("SELECT * FROM customer_information WHERE password = @newPassword AND customer_id = (SELECT customer_id FROM account WHERE account_id = @accountId)", conn);
                cmd.Parameters.AddWithValue("@newPassword", newPassword);
                cmd.Parameters.AddWithValue("@accountId", accountId);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    throw new Exception("The new password is the same as the current one. Please use a different password.");
                }
                reader.Close();
                // Insert the new password update request into the customer_update table
                cmd = new MySqlCommand("INSERT INTO customer_update (account_id, information_type, changed_information, update_status) VALUES (@accountId, 'Password', @newPassword, 'Pending')", conn);
                cmd.Parameters.AddWithValue("@accountId", accountId);
                cmd.Parameters.AddWithValue("@newPassword", newPassword);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
