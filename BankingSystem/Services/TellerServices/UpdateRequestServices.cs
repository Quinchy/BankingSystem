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
        
        }
        public static void ApprovePhoneNumberChange(string updateId)
        {

        }
        public static void ApprovePasswordChange(string updateId)
        {

        }
        public static void RejectUpdate(string updateId)
        {

        }
    }
} 
