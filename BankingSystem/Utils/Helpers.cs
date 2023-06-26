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
                    SELECT tr.reference_number, CONCAT(ci.first_name, ' ', ci.last_name) AS full_name, tr.account_id, th.transaction_type, th.amount, th.date
                    FROM transaction_receipt tr
                    JOIN transaction_history th ON tr.transaction_id = th.transaction_id
                    JOIN account a ON th.account_id = a.account_id
                    JOIN customer_information ci ON a.customer_id = ci.customer_id
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
                            reader.GetString("full_name"), // Will return "first_name last_name"
                            reader.GetString("account_id"),
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
    }
}
