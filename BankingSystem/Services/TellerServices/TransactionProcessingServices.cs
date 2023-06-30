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
    // This class contains all the methods used by TransactionProcessingForm
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
                string sql = @"
                    SELECT COUNT(*) as total_history
                    FROM transaction_history";
                MySqlCommand command = new MySqlCommand(sql, connection);
                totalHistory = Convert.ToInt32(command.ExecuteScalar());
            }
            int totalRejected = 0;
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                string sql = @"
                    SELECT COUNT(*) as total_rejected
                    FROM transaction_processing
                    WHERE process_status = 'Rejected'";
                MySqlCommand command = new MySqlCommand(sql, connection);
                totalRejected = Convert.ToInt32(command.ExecuteScalar());
            }
            return totalHistory + totalRejected;
        }
        public static List<TransactionRequest> RetrieveTransactionRequests(int limit = 4, int offset = 0)
        {
            List<TransactionRequest> requests = new List<TransactionRequest>();
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                string sql = @"
                    SELECT tp.process_id, 
                    CONCAT(c.first_name, ' ', c.last_name) as sender_full_name, 
                    tp.sender_account_id as sender_account_id,
                    a.balance as current_balance, 
                    tp.transaction_type,
                    CASE WHEN tp.transaction_type = 'Transfer' THEN CONCAT(rci.first_name, ' ', rci.last_name) ELSE NULL END as receiver_full_name,
                    CASE WHEN tp.transaction_type = 'Transfer' THEN tp.receiver_account_id ELSE NULL END as receiver_account_id, 
                    tp.amount, 
                    tp.process_status as transaction_status
                    FROM transaction_processing tp
                    JOIN account a ON tp.sender_account_id = a.account_id
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
                    (
                        SELECT
                            th.transaction_id as process_id,
                            CONCAT(c.first_name, ' ', c.last_name) as sender_full_name,
                            th.sender_account_id as sender_account_id,
                            th.transaction_type as transaction_type,
                            th.date as transaction_date,
                            th.transaction_id as transaction_history_id,
                            CONCAT(rci.first_name, ' ', rci.last_name) as receiver_full_name,
                            th.receiver_account_id as receiver_account_id,
                            th.amount as transaction_amount,
                            'Approved' as transaction_status
                        FROM transaction_history th
                        JOIN account a ON th.sender_account_id = a.account_id
                        JOIN customer_information c ON a.customer_id = c.customer_id
                        LEFT JOIN account ra ON th.receiver_account_id = ra.account_id
                        LEFT JOIN customer_information rci ON ra.customer_id = rci.customer_id
                    )
                    UNION ALL
                    (
                        SELECT
                            tp.process_id,
                            CONCAT(c.first_name, ' ', c.last_name) as sender_full_name,
                            tp.sender_account_id as sender_account_id,
                            tp.transaction_type as transaction_type,
                            NULL as transaction_date,
                            NULL as transaction_history_id,
                            CONCAT(rci.first_name, ' ', rci.last_name) as receiver_full_name,
                            tp.receiver_account_id as receiver_account_id,
                            tp.amount as transaction_amount,
                            tp.process_status as transaction_status
                        FROM transaction_processing tp
                        JOIN account a ON tp.sender_account_id = a.account_id
                        JOIN customer_information c ON a.customer_id = c.customer_id
                        LEFT JOIN account ra ON tp.receiver_account_id = ra.account_id
                        LEFT JOIN customer_information rci ON ra.customer_id = rci.customer_id
                        WHERE tp.process_status = 'Rejected'
                    )
                    ORDER BY transaction_date DESC
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
                        JOIN transaction_processing tp ON a.account_id = tp.sender_account_id
                        SET a.balance = a.balance - tp.amount
                        WHERE tp.process_id = @ProcessId";
                    MySqlCommand command2 = new MySqlCommand(sql2, connection);
                    command2.Parameters.AddWithValue("@ProcessId", processId);
                    command2.ExecuteNonQuery();

                    CreateHistoryForTransaction(processId, connection, "Withdraw");
                    GenerateReceiptForTransaction(processId, connection, "Withdraw");

                    string message = "Your " + "withdraw" + " has been approved. Check your transaction history for more details.";
                    CreateNotificationForTransaction(GetCustomerIdFromProcessId(processId), message);
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
                        JOIN transaction_processing tp ON a.account_id = tp.sender_account_id
                        SET a.balance = a.balance + tp.amount
                        WHERE tp.process_id = @ProcessId";
                    MySqlCommand command2 = new MySqlCommand(sql2, connection);
                    command2.Parameters.AddWithValue("@ProcessId", processId);
                    command2.ExecuteNonQuery();

                    CreateHistoryForTransaction(processId, connection, "Deposit");
                    GenerateReceiptForTransaction(processId, connection, "Deposit");

                    string message = "Your " + "deposit" + " has been approved. Check your transaction history for more details.";
                    CreateNotificationForTransaction(GetCustomerIdFromProcessId(processId), message);
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
                        JOIN transaction_processing tp ON a.account_id = tp.sender_account_id
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

                    CreateHistoryForTransaction(processId, connection, "Transfer"); 
                    GenerateReceiptForTransaction(processId, connection, "Transfer");

                    string messageToSender = "Your transfer has been approved. Check your transaction history for more details.";
                    CreateNotificationForTransaction(GetCustomerIdFromProcessId(processId), messageToSender);

                    string messageToReceiver = "You have received a transfer. Check your transaction history for more details.";
                    CreateNotificationForTransaction(GetCustomerIdFromReceiverAccountID(processId), messageToReceiver);
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
            string transactionType;

            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                // Get the sender_account_id and transaction_type from the transaction_processing table
                string sql = "SELECT transaction_type FROM transaction_processing WHERE process_id = @ProcessId";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ProcessId", processId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        transactionType = reader.GetString(0);
                    }
                    else
                    {
                        throw new Exception("Process id not found.");
                    }
                }
            }

            int senderCustomerId = GetCustomerIdFromProcessId(processId); // Use the method you provided earlier to get customer_id

            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                // Update the transaction_processing table
                string sql = "UPDATE transaction_processing SET process_status = 'Rejected' WHERE process_id = @ProcessId";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ProcessId", processId);
                command.ExecuteNonQuery();
            }

            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                // Insert a new notification
                string sql = "INSERT INTO notifications (customer_id, message, is_seen, created_at) VALUES (@CustomerId, @Message, 0, NOW())";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@CustomerId", senderCustomerId);
                command.Parameters.AddWithValue("@Message", $"Your {transactionType} transaction has been rejected by the teller.");

                command.ExecuteNonQuery();
            }
        }
        private static string GenerateReferenceNumber()
        {
            Random rnd = new Random();
            return string.Format("{0:D4}-{1:D3}-{2:D4}", rnd.Next(0, 9999), rnd.Next(0, 999), rnd.Next(0, 9999));
        }
        public static void GenerateReceiptForTransaction(string processId, MySqlConnection connection, string transactionType)
        {
            // Generate reference number
            string referenceNumber = GenerateReferenceNumber();

            // Get the transaction_id of the last inserted row in transaction_history
            string sql1 = "SELECT MAX(transaction_id) FROM transaction_history WHERE sender_account_id IN (SELECT sender_account_id FROM transaction_processing WHERE process_id = @ProcessId)";
            MySqlCommand command1 = new MySqlCommand(sql1, connection);
            command1.Parameters.AddWithValue("@ProcessId", processId);
            string transactionId = command1.ExecuteScalar().ToString();

            // Insert into transaction_receipt
            string sql2 = @"
                INSERT INTO transaction_receipt (reference_number, customer_id, account_id, transaction_id)
                SELECT @ReferenceNumber, a.customer_id, tp.sender_account_id, @TransactionId
                FROM transaction_processing tp
                JOIN account a ON a.account_id = tp.sender_account_id
                WHERE tp.process_id = @ProcessId";
            MySqlCommand command2 = new MySqlCommand(sql2, connection);
            command2.Parameters.AddWithValue("@ReferenceNumber", referenceNumber);
            command2.Parameters.AddWithValue("@ProcessId", processId);
            command2.Parameters.AddWithValue("@TransactionId", transactionId);
            command2.ExecuteNonQuery();
        }

        public static void CreateHistoryForTransaction(string processId, MySqlConnection connection, string transactionType)
        {
            // Select fields depending on the transactionType
            string sql = transactionType == "Transfer" ? @"
                INSERT INTO transaction_history (sender_account_id, receiver_account_id, amount, date, transaction_type)
                SELECT tp.sender_account_id, tp.receiver_account_id, tp.amount, NOW(), tp.transaction_type
                FROM transaction_processing tp
                WHERE tp.process_id = @ProcessId" : @"
                INSERT INTO transaction_history (sender_account_id, amount, date, transaction_type)
                SELECT tp.sender_account_id, tp.amount, NOW(), tp.transaction_type
                FROM transaction_processing tp
                WHERE tp.process_id = @ProcessId";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ProcessId", processId);
            command.ExecuteNonQuery();
        }
        public static void CreateNotificationForTransaction(int customerId, string message)
        {
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                string query = "INSERT INTO notifications (customer_id, message, is_seen) VALUES (@CustomerId, @Message, 0)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerId", customerId);
                    command.Parameters.AddWithValue("@Message", message);
                    command.ExecuteNonQuery();
                }
            }
        }
        public static int GetCustomerIdFromProcessId(string processId)
        {
            int customerId;

            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                string sql = @"
                    SELECT a.customer_id 
                    FROM transaction_processing tp
                    JOIN account a ON tp.sender_account_id = a.account_id
                    WHERE tp.process_id = @ProcessId";

                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ProcessId", processId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        customerId = reader.GetInt32(0); // Assuming customer_id is at index 0
                    }
                    else
                    {
                        throw new Exception("Process id not found.");
                    }
                }
            }

            return customerId;
        }
        public static int GetCustomerIdFromReceiverAccountID(string processId)
        {
            string receiverAccountId;
            int customerId;

            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                // Get the receiver_account_id from the transaction_processing table
                string sql = "SELECT receiver_account_id FROM transaction_processing WHERE process_id = @ProcessId";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ProcessId", processId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        receiverAccountId = reader.GetString(0); // Assuming receiver_account_id is at index 0
                    }
                    else
                    {
                        throw new Exception("Process id not found.");
                    }
                }
            }
            using (MySqlConnection connection = MySQLDatabase.OpenConnection())
            {
                // Get the customer_id from the account table
                string sql = "SELECT customer_id FROM account WHERE account_id = @AccountId";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@AccountId", receiverAccountId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        customerId = reader.GetInt32(0); // Assuming customer_id is at index 0
                    }
                    else
                    {
                        throw new Exception("Account id not found.");
                    }
                }
            }

            return customerId;
        }
    }
}