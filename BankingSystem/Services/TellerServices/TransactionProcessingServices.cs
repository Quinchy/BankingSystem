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
        // Loads a list of transaction requests with pending status from the database
        public static List<TransactionRequest> loadTransactionRequest()
        {
            var transactionRequests = new List<TransactionRequest>();
            // Open a connection to the MySQL database using a connection pool
            using (var conn = MySQLDatabase.OpenConnection())
            {
                // Construct the SQL query to retrieve transaction request information
                string query = @"SELECT tp.process_id, tp.account_id, a.balance, tp.transaction_type, tp.amount, tp.process_status 
                    FROM transaction_processing tp
                    JOIN account a ON tp.account_id = a.account_id
                    WHERE tp.process_status = 'Pending'";
                // Create a MySqlCommand object with the query and connection
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Execute the query and retrieve the data reader
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Iterate through each row in the result set
                        while (reader.Read())
                        {
                            // Extract the transaction request details from the reader
                            var processId = reader["process_id"].ToString();
                            var accountId = reader["account_id"].ToString();
                            var balance = Convert.ToDouble(reader["balance"]);
                            var transactionType = reader["transaction_type"].ToString();
                            var amount = Convert.ToDouble(reader["amount"]);
                            var processStatus = reader["process_status"].ToString();
                            // Create a TransactionRequest object and add it to the list
                            transactionRequests.Add(new TransactionRequest(processId, accountId, balance, transactionType, amount, processStatus));
                        }
                    }
                }
            }
            return transactionRequests;
        }
        // Approves a deposit transaction by updating the balance and process status, and inserting a transaction record
        public static void approveDeposit(string processId)
        {
            using (var conn = MySQLDatabase.OpenConnection())
            {
                string accountId;
                double depositAmount;
                // Retrieve transaction details based on the process ID
                using (var selectCommand = new MySqlCommand("SELECT * FROM transaction_processing WHERE process_id = @processId", conn))
                {
                    selectCommand.Parameters.AddWithValue("@processId", processId);

                    using (var reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            accountId = reader["account_id"].ToString();
                            depositAmount = Convert.ToDouble(reader["amount"]);
                        }
                        else
                        {
                            throw new Exception("Process ID not found.");
                        }
                    }
                }
                // Retrieve current balance of the account
                using (var selectBalanceCommand = new MySqlCommand("SELECT balance FROM Account WHERE account_id = @accountId", conn))
                {
                    selectBalanceCommand.Parameters.AddWithValue("@accountId", accountId);
                    object result = selectBalanceCommand.ExecuteScalar();

                    if (result != null)
                    {
                        double currentBalance = Convert.ToDouble(result);
                        double newBalance = currentBalance + depositAmount;

                        // Update the balance of the account
                        using (var updateBalanceCommand = new MySqlCommand("UPDATE Account SET balance = @balance WHERE account_id = @accountId", conn))
                        {
                            updateBalanceCommand.Parameters.AddWithValue("@accountId", accountId);
                            updateBalanceCommand.Parameters.AddWithValue("@balance", newBalance);
                            updateBalanceCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        throw new Exception("Account ID not found.");
                    }
                }
                // Update the process status to 'Approved'
                using (var updateCommand = new MySqlCommand("UPDATE transaction_processing SET process_status = 'Approved' WHERE process_id = @processId", conn))
                {
                    updateCommand.Parameters.AddWithValue("@processId", processId);
                    updateCommand.ExecuteNonQuery();
                }
                // Insert a record in the transaction history
                using (var insertCommand = new MySqlCommand("INSERT INTO transaction_history (account_id, amount, date, transaction_type) VALUES (@accountId, @amount, NOW(), 'Deposit')", conn))
                {
                    insertCommand.Parameters.AddWithValue("@accountId", accountId);
                    insertCommand.Parameters.AddWithValue("@amount", depositAmount);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }
        // Approves a withdrawal transaction by updating the balance and process status, and inserting a transaction record
        public static void approveWithdraw(string processId)
        {
            using (var conn = MySQLDatabase.OpenConnection())
            {
                string accountId;
                double withdrawAmount;
                // Retrieve transaction details based on the process ID
                using (var selectCommand = new MySqlCommand("SELECT * FROM transaction_processing WHERE process_id = @processId", conn))
                {
                    selectCommand.Parameters.AddWithValue("@processId", processId);
                    using (var reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            accountId = reader["account_id"].ToString();
                            withdrawAmount = Convert.ToDouble(reader["amount"]);
                        }
                        else
                        {
                            throw new Exception("Process ID not found.");
                        }
                    }
                }
                // Retrieve current balance of the account
                using (var selectBalanceCommand = new MySqlCommand("SELECT balance FROM Account WHERE account_id = @accountId", conn))
                {
                    selectBalanceCommand.Parameters.AddWithValue("@accountId", accountId);
                    object result = selectBalanceCommand.ExecuteScalar();
                    if (result != null)
                    {
                        double currentBalance = Convert.ToDouble(result);
                        if (currentBalance < withdrawAmount)
                        {
                            throw new Exception("Insufficient balance.");
                        }
                        double newBalance = currentBalance - withdrawAmount;
                        // Update the balance of the account
                        using (var updateBalanceCommand = new MySqlCommand("UPDATE Account SET balance = @balance WHERE account_id = @accountId", conn))
                        {
                            updateBalanceCommand.Parameters.AddWithValue("@accountId", accountId);
                            updateBalanceCommand.Parameters.AddWithValue("@balance", newBalance);
                            updateBalanceCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        throw new Exception("Account ID not found.");
                    }
                }
                // Update the process status to 'Approved'
                using (var updateCommand = new MySqlCommand("UPDATE transaction_processing SET process_status = 'Approved' WHERE process_id = @processId", conn))
                {
                    updateCommand.Parameters.AddWithValue("@processId", processId);
                    updateCommand.ExecuteNonQuery();
                }
                // Insert a record in the transaction history
                using (var insertCommand = new MySqlCommand("INSERT INTO transaction_history (account_id, amount, date, transaction_type) VALUES (@accountId, @amount, NOW(), 'Withdraw')", conn))
                {
                    insertCommand.Parameters.AddWithValue("@accountId", accountId);
                    insertCommand.Parameters.AddWithValue("@amount", withdrawAmount);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }
        // Approves a transfer transaction by updating balances and process status, and inserting a transaction record
        public static void approveTransfer(string processId)
        {
            using (var conn = MySQLDatabase.OpenConnection())
            {
                string senderAccountId;
                string receiverAccountId;
                double transferAmount;
                // Retrieve transaction details based on the process ID
                using (var selectCommand = new MySqlCommand("SELECT * FROM transaction_processing WHERE process_id = @processId", conn))
                {
                    selectCommand.Parameters.AddWithValue("@processId", processId);

                    using (var reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            senderAccountId = reader["account_id"].ToString();
                            receiverAccountId = reader["receiver_account_id"].ToString();
                            transferAmount = Convert.ToDouble(reader["amount"]);
                        }
                        else
                        {
                            throw new Exception("Process ID not found.");
                        }
                    }
                }
                // Update sender's account balance
                using (var updateBalanceCommand = new MySqlCommand("UPDATE Account SET balance = balance - @amount WHERE account_id = @accountId", conn))
                {
                    updateBalanceCommand.Parameters.AddWithValue("@amount", transferAmount);
                    updateBalanceCommand.Parameters.AddWithValue("@accountId", senderAccountId);
                    int rowsAffected = updateBalanceCommand.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("Sender's Account ID not found.");
                    }
                }
                // Update receiver's account balance
                using (var updateBalanceCommand = new MySqlCommand("UPDATE Account SET balance = balance + @amount WHERE account_id = @accountId", conn))
                {
                    updateBalanceCommand.Parameters.AddWithValue("@amount", transferAmount);
                    updateBalanceCommand.Parameters.AddWithValue("@accountId", receiverAccountId);
                    int rowsAffected = updateBalanceCommand.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("Receiver's Account ID not found.");
                    }
                }
                // Update the process status to 'Approved'
                using (var updateCommand = new MySqlCommand("UPDATE transaction_processing SET process_status = 'Approved' WHERE process_id = @processId", conn))
                {
                    updateCommand.Parameters.AddWithValue("@processId", processId);
                    updateCommand.ExecuteNonQuery();
                }
                // Insert a record in the transaction history
                using (var insertCommand = new MySqlCommand("INSERT INTO transaction_history (account_id, amount, date, transaction_type) VALUES (@accountId, @amount, NOW(), 'Transfer')", conn))
                {
                    insertCommand.Parameters.AddWithValue("@accountId", senderAccountId);
                    insertCommand.Parameters.AddWithValue("@amount", transferAmount);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }
        // Rejects a transaction by updating the process status in the database
        public static void rejectTransaction(string processId)
        {
            // Open a connection to the MySQL database using a connection pool
            using (var conn = MySQLDatabase.OpenConnection())
            {
                // Construct the SQL query to update the process status
                string query = "UPDATE transaction_processing SET process_status = 'Rejected' WHERE process_id = @ProcessId";
                // Create a MySqlCommand object with the query and connection
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Add the process ID as a parameter to the query to prevent SQL injection
                    cmd.Parameters.AddWithValue("@ProcessId", processId);
                    // Execute the query to update the process status
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}