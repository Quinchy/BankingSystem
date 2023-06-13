using BankingSystem.Database;
using BankingSystem.Models.TellerModels;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Services.TellerServices
{
    internal class UpdateRequestServices
    {
        public static List<UpdateRequest> loadUpdateRequest()
        {
            var updateRequests = new List<UpdateRequest>();
            using (MySqlConnection conn = MySQLDatabase.OpenConnection())
            {
                // Construct the SQL query to retrieve update request information where update_status is 'Pending'
                string query = @"SELECT * FROM customer_update WHERE update_status = 'Pending'";
                // Create a MySqlCommand object with the query and connection
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Execute the query and retrieve the data reader
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Iterate through each row in the result set
                        while (reader.Read())
                        {
                            // Extract the update request details from the reader
                            var updateId = reader["update_id"].ToString();
                            var accountId = reader["account_id"].ToString();
                            var informationType = reader["information_type"].ToString();
                            var changedInformation = reader["changed_information"].ToString();
                            var updateStatus = reader["update_status"].ToString();
                            // Create an UpdateRequest object and add it to the list
                            updateRequests.Add(new UpdateRequest(updateId, accountId, informationType, changedInformation, updateStatus));
                        }
                    }
                }
            }
            return updateRequests;
        }
        public static void approveEmailUpdate(string updateId)
        {
            using (MySqlConnection conn = MySQLDatabase.OpenConnection())
            {
                // Using the updateId, get the accountId and the new email from the customer_update table
                MySqlCommand cmd = new MySqlCommand("SELECT account_id, changed_information FROM customer_update WHERE update_id = @updateId", conn);
                cmd.Parameters.AddWithValue("@updateId", updateId);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string accountId = reader["account_id"].ToString();
                    string newEmail = reader["changed_information"].ToString();
                    reader.Close();
                    // Update the email of the account in the customer_information table
                    cmd = new MySqlCommand("UPDATE customer_information SET email = @newEmail WHERE customer_id = (SELECT customer_id FROM account WHERE account_id = @accountId)", conn);
                    cmd.Parameters.AddWithValue("@newEmail", newEmail);
                    cmd.Parameters.AddWithValue("@accountId", accountId);
                    cmd.ExecuteNonQuery();
                    // Set the update status to 'Approved' in the customer_update table
                    cmd = new MySqlCommand("UPDATE customer_update SET update_status = 'Approved' WHERE update_id = @updateId", conn);
                    cmd.Parameters.AddWithValue("@updateId", updateId);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    Console.WriteLine("No update request found with the given updateId.");
                }
            }
        }
        public static void approvePhoneNumberUpdate(string updateId)
        {
            using (MySqlConnection conn = MySQLDatabase.OpenConnection())
            {
                // Using the updateId, get the accountId and the new phone number from the customer_update table
                MySqlCommand cmd = new MySqlCommand("SELECT account_id, changed_information FROM customer_update WHERE update_id = @updateId", conn);
                cmd.Parameters.AddWithValue("@updateId", updateId);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string accountId = reader["account_id"].ToString();
                    string newPhoneNumber = reader["changed_information"].ToString();
                    reader.Close();
                    // Update the phone number of the account in the customer_information table
                    cmd = new MySqlCommand("UPDATE customer_information SET phone_number = @newPhoneNumber WHERE customer_id = (SELECT customer_id FROM account WHERE account_id = @accountId)", conn);
                    cmd.Parameters.AddWithValue("@newPhoneNumber", newPhoneNumber);
                    cmd.Parameters.AddWithValue("@accountId", accountId);
                    cmd.ExecuteNonQuery();
                    // Set the update status to 'Approved' in the customer_update table
                    cmd = new MySqlCommand("UPDATE customer_update SET update_status = 'Approved' WHERE update_id = @updateId", conn);
                    cmd.Parameters.AddWithValue("@updateId", updateId);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    Console.WriteLine("No update request found with the given updateId.");
                }
            }
        }
        public static void approvePasswordUpdate(string updateId)
        {
            using (MySqlConnection conn = MySQLDatabase.OpenConnection())
            {
                // Using the updateId, get the accountId and the new password from the customer_update table
                MySqlCommand cmd = new MySqlCommand("SELECT account_id, changed_information FROM customer_update WHERE update_id = @updateId", conn);
                cmd.Parameters.AddWithValue("@updateId", updateId);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string accountId = reader["account_id"].ToString();
                    string newPassword = reader["changed_information"].ToString();
                    reader.Close();
                    // Update the password of the account in the customer_information table
                    cmd = new MySqlCommand("UPDATE customer_information SET password = @newPassword WHERE customer_id = (SELECT customer_id FROM account WHERE account_id = @accountId)", conn);
                    cmd.Parameters.AddWithValue("@newPassword", newPassword);
                    cmd.Parameters.AddWithValue("@accountId", accountId);
                    cmd.ExecuteNonQuery();
                    // Set the update status to 'Approved' in the customer_update table
                    cmd = new MySqlCommand("UPDATE customer_update SET update_status = 'Approved' WHERE update_id = @updateId", conn);
                    cmd.Parameters.AddWithValue("@updateId", updateId);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    Console.WriteLine("No update request found with the given updateId.");
                }
            }
        }
        public static void rejectUpdate(string updateId)
        {
            using (MySqlConnection conn = MySQLDatabase.OpenConnection())
            {
                // Set the update status to 'Rejected' in the customer_update table
                MySqlCommand cmd = new MySqlCommand("UPDATE customer_update SET update_status = 'Rejected' WHERE update_id = @updateId", conn);
                cmd.Parameters.AddWithValue("@updateId", updateId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
