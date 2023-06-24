using BankingSystem.Database;
using BankingSystem.Models.TellerModels;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Services.TellerServices
{
    internal class UpdateRequestServices
    {
        public static int RetrieveTotalUpdateRequests()
        {
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                string sql = "SELECT COUNT(*) FROM customer_update WHERE update_status = 'Pending'";
                MySqlCommand command = new MySqlCommand(sql, connection);
                int totalRequests = Convert.ToInt32(command.ExecuteScalar());
                return totalRequests;
            }
        }
        public static List<UpdateRequest> RetrieveUpdateRequests(int limit = 4, int offset = 0)
        {
            List<UpdateRequest> updates = new List<UpdateRequest>();

            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                string sql = @"
                    SELECT cu.*, CONCAT(ci.first_name, ' ', ci.last_name) AS FullName,
                    CASE 
                    WHEN cu.information_type = 'Email' THEN ci.email
                    WHEN cu.information_type = 'Phone Number' THEN ci.phone_number
                    WHEN cu.information_type = 'Password' THEN ci.password
                    ELSE NULL
                    END as CurrentInformation
                    FROM customer_update cu
                    JOIN account a ON cu.account_id = a.account_id
                    JOIN customer_information ci ON a.customer_id = ci.customer_id
                    WHERE cu.update_status = 'Pending'
                    ORDER BY cu.update_id DESC
                    LIMIT @Limit OFFSET @Offset";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Limit", limit);
                command.Parameters.AddWithValue("@Offset", offset);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    UpdateRequest update = new UpdateRequest(
                            reader.GetString("update_id"),
                            reader.GetString("update_status"),
                            reader.GetString("FullName"),
                            reader.GetString("account_id"),
                            reader.GetString("information_type"),
                            reader.IsDBNull(reader.GetOrdinal("CurrentInformation")) ? null : reader.GetString("CurrentInformation"),
                            reader.GetString("changed_information")
                        );
                    updates.Add(update);
                }
            }
            return updates;
        }
        public static void ApproveEmailChange(string updateId)
        {
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                string updateSql = @"
                    UPDATE customer_update 
                    SET update_status = 'Approved' 
                    WHERE update_id = @UpdateId";
                MySqlCommand updateCommand = new MySqlCommand(updateSql, connection);
                updateCommand.Parameters.AddWithValue("@UpdateId", updateId);
                updateCommand.ExecuteNonQuery();

                string selectSql = @"
                    SELECT account_id, changed_information 
                    FROM customer_update 
                    WHERE update_id = @UpdateId";
                MySqlCommand selectCommand = new MySqlCommand(selectSql, connection);
                selectCommand.Parameters.AddWithValue("@UpdateId", updateId);
                MySqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read())
                {
                    string accountId = reader.GetString("account_id");
                    string changedEmail = reader.GetString("changed_information");
                    reader.Close();

                    string updateCustomerSql = @"
                        UPDATE customer_information 
                        SET email = @ChangedEmail 
                        WHERE customer_id = (
                        SELECT customer_id 
                        FROM account 
                        WHERE account_id = @AccountId)";
                    MySqlCommand updateCustomerCommand = new MySqlCommand(updateCustomerSql, connection);
                    updateCustomerCommand.Parameters.AddWithValue("@ChangedEmail", changedEmail);
                    updateCustomerCommand.Parameters.AddWithValue("@AccountId", accountId);
                    updateCustomerCommand.ExecuteNonQuery();
                }
            }
        }
        public static void ApprovePhoneNumberChange(string updateId)
        {
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                string updateSql = @"
                    UPDATE customer_update 
                    SET update_status = 'Approved' 
                    WHERE update_id = @UpdateId";
                MySqlCommand updateCommand = new MySqlCommand(updateSql, connection);
                updateCommand.Parameters.AddWithValue("@UpdateId", updateId);
                updateCommand.ExecuteNonQuery();

                string selectSql = @"
                    SELECT account_id, changed_information 
                    FROM customer_update 
                    WHERE update_id = @UpdateId";
                MySqlCommand selectCommand = new MySqlCommand(selectSql, connection);
                selectCommand.Parameters.AddWithValue("@UpdateId", updateId);
                MySqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read())
                {
                    string accountId = reader.GetString("account_id");
                    string changedPhoneNumber = reader.GetString("changed_information");
                    reader.Close();

                    string updateCustomerSql = @"
                        UPDATE customer_information 
                        SET phone_number = @ChangedPhoneNumber 
                        WHERE customer_id = (
                        SELECT customer_id 
                        FROM account 
                        WHERE account_id = @AccountId)";
                    MySqlCommand updateCustomerCommand = new MySqlCommand(updateCustomerSql, connection);
                    updateCustomerCommand.Parameters.AddWithValue("@ChangedPhoneNumber", changedPhoneNumber);
                    updateCustomerCommand.Parameters.AddWithValue("@AccountId", accountId);
                    updateCustomerCommand.ExecuteNonQuery();
                }
            }
        }

        public static void ApprovePasswordChange(string updateId)
        {
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                string updateSql = @"
                    UPDATE customer_update 
                    SET update_status = 'Approved' 
                    WHERE update_id = @UpdateId";
                MySqlCommand updateCommand = new MySqlCommand(updateSql, connection);
                updateCommand.Parameters.AddWithValue("@UpdateId", updateId);
                updateCommand.ExecuteNonQuery();

                string selectSql = @"
                    SELECT account_id, changed_information 
                    FROM customer_update 
                    WHERE update_id = @UpdateId";
                MySqlCommand selectCommand = new MySqlCommand(selectSql, connection);
                selectCommand.Parameters.AddWithValue("@UpdateId", updateId);
                MySqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read())
                {
                    string accountId = reader.GetString("account_id");
                    string changedPassword = reader.GetString("changed_information");
                    reader.Close();

                    string updateCustomerSql = @"
                        UPDATE customer_information 
                        SET password = @ChangedPassword 
                        WHERE customer_id = (
                        SELECT customer_id 
                        FROM account 
                        WHERE account_id = @AccountId)";
                    MySqlCommand updateCustomerCommand = new MySqlCommand(updateCustomerSql, connection);
                    updateCustomerCommand.Parameters.AddWithValue("@ChangedPassword", changedPassword);
                    updateCustomerCommand.Parameters.AddWithValue("@AccountId", accountId);
                    updateCustomerCommand.ExecuteNonQuery();
                }
            }
        }
        public static void RejectUpdate(string updateId)
        {
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                string sql = @"
                    UPDATE customer_update 
                    SET update_status = 'Rejected' 
                    WHERE update_id = @UpdateId";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@UpdateId", updateId);
                command.ExecuteNonQuery();
            }
        }
    }
} 
