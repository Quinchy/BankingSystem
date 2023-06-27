using BankingSystem.Database;
using BankingSystem.Models.CustomerModels;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Utils
{
    // A class for methods to be use globally in the app.
    internal class Helpers
    {
        // This method changes the currently displayed Form in the panel of BaseForm.
        // It clear and add the new specified Form to that panel.
        public static void changeScreen(Control baseFormPanel, Form newForm)
        {
            foreach (Control control in baseFormPanel.Controls)
            {
                if (control is Form form)
                {
                    form.Dispose(); // Dispose the form
                }
            }
            baseFormPanel.Controls.Clear();
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            baseFormPanel.Controls.Add(newForm);
            newForm.Show();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        public static Receipt GetReceiptFromDatabase(string transactionId)
        {
            Receipt receipt = null;
            // Open a connection to the MySQL database
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                // SQL query to retrieve receipt
                string sql = @"
                    SELECT tr.reference_number, 
                        CONCAT(ci_sender.first_name, ' ', ci_sender.last_name) AS sender_full_name, 
                        th.sender_account_id, 
                        CONCAT(ci_receiver.first_name, ' ', ci_receiver.last_name) AS receiver_full_name,
                        th.receiver_account_id,
                        th.transaction_type, 
                        th.amount, 
                        th.date
                    FROM transaction_receipt tr
                    JOIN transaction_history th ON tr.transaction_id = th.transaction_id
                    JOIN account a_sender ON th.sender_account_id = a_sender.account_id
                    JOIN customer_information ci_sender ON a_sender.customer_id = ci_sender.customer_id
                    LEFT JOIN account a_receiver ON th.receiver_account_id = a_receiver.account_id
                    LEFT JOIN customer_information ci_receiver ON a_receiver.customer_id = ci_receiver.customer_id
                    WHERE tr.transaction_id = @TransactionId";
                MySqlCommand command = new MySqlCommand(sql, connection);
                // Use the transactionId parameter in the SQL query
                command.Parameters.AddWithValue("@TransactionId", transactionId);
                // Execute the command and process the results
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        receipt = new Receipt(
                            reader.GetString("sender_full_name"),
                            reader.GetString("sender_account_id"),
                            reader.IsDBNull(reader.GetOrdinal("receiver_full_name")) ? null : reader.GetString("receiver_full_name"),
                            reader.IsDBNull(reader.GetOrdinal("receiver_account_id")) ? null : reader.GetString("receiver_account_id"),
                            reader.GetString("transaction_type"),
                            reader.GetDouble("amount"),
                            reader.GetString("reference_number"),
                            reader.GetDateTime("date")
                        );
                    }
                }
            }
            return receipt;
        }
        public static string GetAccountIdByEmail(string email)
        {
            string accountId = null;

            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                string query = @"SELECT a.account_id
                        FROM customer_information c
                        JOIN account a ON c.customer_id = a.customer_id
                        WHERE c.email = @Email";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            accountId = reader["account_id"].ToString();
                        }
                    }
                }
            }

            return accountId;
        }

    }
}
