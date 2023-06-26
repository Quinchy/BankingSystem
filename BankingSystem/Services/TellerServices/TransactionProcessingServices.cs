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
    // A service class for managing customer' transaction request. Also performs the withdrawal, deposit and transfer of money.
    internal class TransactionProcessingServices
    {
        public static int RetrieveTotalTransactionRequests()
        {
            int totalRequests = 0;
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                string sql = "SELECT COUNT(*) FROM transaction_processing WHERE process_status = 'Pending'";
                MySqlCommand command = new MySqlCommand(sql, connection);
                totalRequests = Convert.ToInt32(command.ExecuteScalar());
            }
            return totalRequests;
        }
        public static int RetrieveTotalTransactionHistory()
        {
            int totalHistory = 0;
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                string sql = @"SELECT COUNT(*) FROM transaction_processing WHERE process_status IN ('Approved', 'Rejected')";
                MySqlCommand command = new MySqlCommand(sql, connection);
                totalHistory = Convert.ToInt32(command.ExecuteScalar());
            }
            return totalHistory;
        }
        public static List<TransactionRequest> RetrieveTransactionRequests(int limit = 4, int offset = 0)
        {
            List<TransactionRequest> requests = new List<TransactionRequest>();
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                string sql = @"
                    SELECT tp.process_id, CONCAT(c.first_name, ' ', c.last_name) as sender_full_name, tp.account_id as sender_account_id,
                    a.balance as current_balance, tp.transaction_type,
                    CASE WHEN tp.transaction_type = 'Transfer' THEN CONCAT(rci.first_name, ' ', rci.last_name) ELSE NULL END as receiver_full_name,
                    CASE WHEN tp.transaction_type = 'Transfer' THEN tp.receiver_account_id ELSE NULL END as receiver_account_id, 
                    tp.amount, tp.process_status as transaction_status
                    FROM transaction_processing tp
                    JOIN account a ON tp.account_id = a.account_id
                    JOIN customer_information c ON a.customer_id = c.customer_id
                    LEFT JOIN account ra ON tp.receiver_account_id = ra.account_id AND tp.transaction_type = 'Transfer'
                    LEFT JOIN customer_information rci ON ra.customer_id = rci.customer_id AND tp.transaction_type = 'Transfer'
                    WHERE tp.process_status = 'Pending'
                    ORDER BY tp.process_id ASC
                    LIMIT @Limit
                    OFFSET @Offset";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Limit", limit);
                command.Parameters.AddWithValue("@Offset", offset);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TransactionRequest request = new TransactionRequest(
                            reader.GetString("process_id"),
                            reader.GetString("sender_full_name"),
                            reader.GetString("sender_account_id"),
                            reader.GetDouble("current_balance"),
                            reader.GetString("transaction_type"),
                            reader.IsDBNull(reader.GetOrdinal("receiver_full_name")) ? null : reader.GetString("receiver_full_name"),
                            reader.IsDBNull(reader.GetOrdinal("receiver_account_id")) ? null : reader.GetString("receiver_account_id"),
                            reader.GetDouble("amount"),
                            reader.GetString("transaction_status")
                        );
                        requests.Add(request);
                    }
                }
            }
            return requests;
        }
        public static List<Transaction> RetrieveTransactionHistory(int limit = 4, int offset = 0)
        {
            List<Transaction> transactions = new List<Transaction>();
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                string sql = @"
                    SELECT tp.process_id, CONCAT(c.first_name, ' ', c.last_name) as sender_full_name, tp.account_id as sender_account_id,
                    CASE WHEN tp.process_status = 'Approved' THEN th.transaction_type ELSE tp.transaction_type END as transaction_type,
                    th.date as transaction_date, th.transaction_id as transaction_history_id,
                    CASE WHEN th.transaction_type = 'Transfer' THEN CONCAT(rci.first_name, ' ', rci.last_name) ELSE NULL END as receiver_full_name,
                    CASE WHEN th.transaction_type = 'Transfer' THEN tp.receiver_account_id ELSE NULL END as receiver_account_id, 
                    CASE WHEN tp.process_status = 'Approved' THEN th.amount ELSE tp.amount END as transaction_amount,
                    tp.process_status as transaction_status
                    FROM transaction_processing tp
                    JOIN account a ON tp.account_id = a.account_id
                    JOIN customer_information c ON a.customer_id = c.customer_id
                    LEFT JOIN account ra ON tp.receiver_account_id = ra.account_id
                    LEFT JOIN customer_information rci ON ra.customer_id = rci.customer_id
                    LEFT JOIN transaction_history th ON tp.account_id = th.account_id AND tp.process_status = 'Approved'
                    WHERE tp.process_status IN ('Approved', 'Rejected')
                    ORDER BY tp.process_id DESC
                    LIMIT @Limit
                    OFFSET @Offset";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Limit", limit);
                command.Parameters.AddWithValue("@Offset", offset);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Transaction transaction = new Transaction(
                            reader.GetString("process_id"),
                            reader.GetString("sender_full_name"),
                            reader.GetString("sender_account_id"),
                            reader.GetString("transaction_type"),
                            reader.IsDBNull(reader.GetOrdinal("transaction_date")) ? DateTime.MinValue : reader.GetDateTime("transaction_date"),
                            reader.IsDBNull(reader.GetOrdinal("transaction_history_id")) ? null : reader.GetString("transaction_history_id"),
                            reader.IsDBNull(reader.GetOrdinal("receiver_full_name")) ? null : reader.GetString("receiver_full_name"),
                            reader.IsDBNull(reader.GetOrdinal("receiver_account_id")) ? null : reader.GetString("receiver_account_id"),
                            reader.GetDouble("transaction_amount"),
                            reader.GetString("transaction_status")
                        );
                        transactions.Add(transaction);
                    }
                }
            }
            return transactions;
        }
        public static void ApproveWithdraw(string processId)
        {
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                MySqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Update process_status in transaction_processing table
                    string sql1 = "UPDATE transaction_processing SET process_status = 'Approved' WHERE process_id = @ProcessId";
                    MySqlCommand command1 = new MySqlCommand(sql1, connection);
                    command1.Parameters.AddWithValue("@ProcessId", processId);
                    command1.ExecuteNonQuery();

                    // Perform withdrawal and update account balance
                    string sql2 = @"
                        UPDATE account a
                        JOIN transaction_processing tp ON a.account_id = tp.account_id
                        SET a.balance = a.balance - tp.amount
                        WHERE tp.process_id = @ProcessId";
                    MySqlCommand command2 = new MySqlCommand(sql2, connection);
                    command2.Parameters.AddWithValue("@ProcessId", processId);
                    command2.ExecuteNonQuery();

                    // Create History for transaction
                    CreateHistoryForTransaction(processId, connection);

                    // Generate Receipt for transaction
                    GenerateReceiptForTransaction(processId, connection);

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
        public static void ApproveDeposit(string processId)
        {
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                MySqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Update process_status in transaction_processing table
                    string sql1 = "UPDATE transaction_processing SET process_status = 'Approved' WHERE process_id = @ProcessId";
                    MySqlCommand command1 = new MySqlCommand(sql1, connection);
                    command1.Parameters.AddWithValue("@ProcessId", processId);
                    command1.ExecuteNonQuery();

                    // Perform deposit and update account balance
                    string sql2 = @"
                        UPDATE account a
                        JOIN transaction_processing tp ON a.account_id = tp.account_id
                        SET a.balance = a.balance + tp.amount
                        WHERE tp.process_id = @ProcessId";
                    MySqlCommand command2 = new MySqlCommand(sql2, connection);
                    command2.Parameters.AddWithValue("@ProcessId", processId);
                    command2.ExecuteNonQuery();

                    // Create History for transaction
                    CreateHistoryForTransaction(processId, connection);

                    // Generate Receipt for transaction
                    GenerateReceiptForTransaction(processId, connection);

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
        public static void ApproveTransfer(string processId)
        {
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                MySqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    // Update process_status in transaction_processing table
                    string sql1 = "UPDATE transaction_processing SET process_status = 'Approved' WHERE process_id = @ProcessId";
                    MySqlCommand command1 = new MySqlCommand(sql1, connection);
                    command1.Parameters.AddWithValue("@ProcessId", processId);
                    command1.ExecuteNonQuery();

                    // Perform transfer and update account balances
                    string sql2 = @"
                        UPDATE account a
                        JOIN transaction_processing tp ON a.account_id = tp.account_id
                        SET a.balance = a.balance - tp.amount
                        WHERE tp.process_id = @ProcessId";
                    MySqlCommand command2 = new MySqlCommand(sql2, connection);
                    command2.Parameters.AddWithValue("@ProcessId", processId);
                    command2.ExecuteNonQuery();

                    string sql3 = @"
                        UPDATE account a
                        JOIN transaction_processing tp ON a.account_id = tp.receiver_account_id
                        SET a.balance = a.balance + tp.amount
                        WHERE tp.process_id = @ProcessId";
                    MySqlCommand command3 = new MySqlCommand(sql3, connection);
                    command3.Parameters.AddWithValue("@ProcessId", processId);
                    command3.ExecuteNonQuery();

                    // Create History for transaction
                    CreateHistoryForTransaction(processId, connection);

                    // Generate Receipt for transaction
                    GenerateReceiptForTransaction(processId, connection);

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
        public static void RejectTransaction(string processId)
        {
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                string sql = "UPDATE transaction_processing SET process_status = 'Rejected' WHERE process_id = @ProcessId";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ProcessId", processId);
                command.ExecuteNonQuery();
            }
        }
        private static string GenerateReferenceNumber()
        {
            Random rnd = new Random();
            return string.Format("{0:D4}-{1:D3}-{2:D4}", rnd.Next(0, 9999), rnd.Next(0, 999), rnd.Next(0, 9999));
        }
        public static void GenerateReceiptForTransaction(string processId, MySqlConnection connection)
        {
            // Generate reference number
            string referenceNumber = GenerateReferenceNumber();

            // Get the transaction_id of the last inserted row in transaction_history
            string sql1 = "SELECT MAX(transaction_id) FROM transaction_history WHERE account_id IN (SELECT account_id FROM transaction_processing WHERE process_id = @ProcessId)";
            MySqlCommand command1 = new MySqlCommand(sql1, connection);
            command1.Parameters.AddWithValue("@ProcessId", processId);
            string transactionId = command1.ExecuteScalar().ToString();

            // Insert into transaction_receipt
            string sql2 = @"
                INSERT INTO transaction_receipt (reference_number, customer_id, account_id, transaction_id)
                SELECT @ReferenceNumber, a.customer_id, tp.account_id, @TransactionId
                FROM transaction_processing tp
                JOIN account a ON a.account_id = tp.account_id
                WHERE tp.process_id = @ProcessId";
            MySqlCommand command2 = new MySqlCommand(sql2, connection);
            command2.Parameters.AddWithValue("@ReferenceNumber", referenceNumber);
            command2.Parameters.AddWithValue("@ProcessId", processId);
            command2.Parameters.AddWithValue("@TransactionId", transactionId);
            command2.ExecuteNonQuery();
        }
        public static void CreateHistoryForTransaction(string processId, MySqlConnection connection)
        {
            // Insert into transaction_history
            string sql = @"
                INSERT INTO transaction_history (account_id, amount, date, transaction_type)
                SELECT tp.account_id, tp.amount, NOW(), tp.transaction_type
                FROM transaction_processing tp
                WHERE tp.process_id = @ProcessId";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ProcessId", processId);
            command.ExecuteNonQuery();
        }
    }
}