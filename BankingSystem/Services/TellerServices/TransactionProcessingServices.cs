using BankingSystem.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Services.TellerServices
{
    internal class TransactionProcessingServices
    {
        public static void loadTransactionRequest(ListView transactionProcessingListView)
        {
            using (var conn = MySQLDatabase.OpenConnection())
            {
                string query = @"SELECT tp.process_id, tp.account_id, a.balance, tp.transaction_type, tp.amount, tp.process_status 
                         FROM transaction_processing tp
                         JOIN account a ON tp.account_id = a.account_id
                         WHERE tp.process_status = 'Pending'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["process_id"].ToString());
                        item.SubItems.Add(reader["account_id"].ToString());
                        item.SubItems.Add(reader["balance"].ToString());
                        item.SubItems.Add(reader["transaction_type"].ToString());
                        item.SubItems.Add(reader["amount"].ToString());
                        item.SubItems.Add(reader["process_status"].ToString());
                        transactionProcessingListView.Items.Add(item);
                    }
                }
            }
        }
        public static void approveDeposit(string processId)
        {
            using (var conn = MySQLDatabase.OpenConnection())
            {
                string accountId;
                double depositAmount;

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

                using (var selectBalanceCommand = new MySqlCommand("SELECT balance FROM Account WHERE account_id = @accountId", conn))
                {
                    selectBalanceCommand.Parameters.AddWithValue("@accountId", accountId);
                    object result = selectBalanceCommand.ExecuteScalar();
                    if (result != null)
                    {
                        double currentBalance = Convert.ToDouble(result);
                        double newBalance = currentBalance + depositAmount;

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

                using (var updateCommand = new MySqlCommand("UPDATE transaction_processing SET process_status = 'Approved' WHERE process_id = @processId", conn))
                {
                    updateCommand.Parameters.AddWithValue("@processId", processId);
                    updateCommand.ExecuteNonQuery();
                }

                using (var insertCommand = new MySqlCommand("INSERT INTO transaction_history (account_id, amount, date, transaction_type) VALUES (@accountId, @amount, NOW(), 'Deposit')", conn))
                {
                    insertCommand.Parameters.AddWithValue("@accountId", accountId);
                    insertCommand.Parameters.AddWithValue("@amount", depositAmount);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }
        public static void approveWithdraw(string processId)
        {
            using (var conn = MySQLDatabase.OpenConnection())
            {
                string accountId;
                double withdrawAmount;

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

                using (var updateCommand = new MySqlCommand("UPDATE transaction_processing SET process_status = 'Approved' WHERE process_id = @processId", conn))
                {
                    updateCommand.Parameters.AddWithValue("@processId", processId);
                    updateCommand.ExecuteNonQuery();
                }

                using (var insertCommand = new MySqlCommand("INSERT INTO transaction_history (account_id, amount, date, transaction_type) VALUES (@accountId, @amount, NOW(), 'Withdraw')", conn))
                {
                    insertCommand.Parameters.AddWithValue("@accountId", accountId);
                    insertCommand.Parameters.AddWithValue("@amount", withdrawAmount);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
