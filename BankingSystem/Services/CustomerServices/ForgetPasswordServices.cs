using BankingSystem.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Services.CustomerServices
{
    internal class ForgetPasswordServices
    {
        public static void requestResetPassword(string email, string newPassword)
        {
            using (MySqlConnection conn = MySQLDatabase.OpenConnection())
            {
                // Check if the email exists in the customer_information table and get the associated account_id from the account table
                MySqlCommand cmd = new MySqlCommand("SELECT a.account_id FROM customer_information ci JOIN account a ON ci.customer_id = a.customer_id WHERE ci.email = @email", conn);
                cmd.Parameters.AddWithValue("@email", email);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (!reader.Read())
                {
                    throw new Exception("The provided email does not exist.");
                }
                string accountId = reader["account_id"].ToString();
                reader.Close();
                // Check if there's a pending request in the customer_update table
                cmd = new MySqlCommand("SELECT * FROM customer_update WHERE account_id = @accountId AND update_status = 'Pending'", conn);
                cmd.Parameters.AddWithValue("@accountId", accountId);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    throw new Exception("There is already a pending request for this account.");
                }
                reader.Close();
                // Insert a new row in the customer_update table
                cmd = new MySqlCommand("INSERT INTO customer_update (account_id, information_type, changed_information, update_status) VALUES (@accountId, 'Password', @newPassword, 'Pending')", conn);
                cmd.Parameters.AddWithValue("@accountId", accountId);
                cmd.Parameters.AddWithValue("@newPassword", newPassword);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
