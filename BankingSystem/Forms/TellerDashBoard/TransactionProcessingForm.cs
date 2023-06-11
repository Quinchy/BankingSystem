using BankingSystem.Models;
using BankingSystem.Services.CustomerServices;
using BankingSystem.Services.TellerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSystem.Forms.TellerDashBoard
{
    public partial class TransactionProcessingForm : Form
    {
        public TransactionProcessingForm()
        {
            InitializeComponent();
            InitializeTransactionProcessingListView();
        }
        // Handles the Click event of the approve button.
        // Approves all checked transactions in the ListView.
        private void approveButton_Click(object sender, EventArgs e)
        {
            // Check if any transactions are selected
            if (transactionProcessingListView.CheckedItems.Count > 0)
            {
                // Iterate over all checked items in the ListView
                foreach (ListViewItem selectedItem in transactionProcessingListView.CheckedItems)
                {
                    string processId = selectedItem.SubItems[0].Text;
                    string transactionType = selectedItem.SubItems[3].Text;                   
                    try
                    {
                        // Approve the transaction.
                        switch (transactionType)
                        {
                            case "Deposit":
                                TransactionProcessingServices.approveDeposit(processId);
                                break;
                            case "Withdraw":
                                TransactionProcessingServices.approveWithdraw(processId);
                                break;
                            case "Transfer":
                                TransactionProcessingServices.approveTransfer(processId);
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                // Refresh the transaction processing list view
                InitializeTransactionProcessingListView();
            }
            else
            {
                MessageBox.Show("Please check a transaction to approve.");
            }
        }
        // Handles the Click event of the reject button.
        // Rejects all checked transactions in the ListView.
        private void rejectButton_Click(object sender, EventArgs e)
        {
            // Check if any transactions are selected
            if (transactionProcessingListView.CheckedItems.Count > 0)
            {
                // Iterate over all checked items in the ListView
                foreach (ListViewItem selectedItem in transactionProcessingListView.CheckedItems)
                {
                    string processId = selectedItem.SubItems[0].Text;                 
                    try
                    {
                        // Reject the transaction.
                        TransactionProcessingServices.rejectTransaction(processId);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                // Refresh the transaction processing list view
                InitializeTransactionProcessingListView();
            }
            else
            {
                MessageBox.Show("Please check a transaction to reject.");
            }
        }
        // Initializes the transaction processing ListView with data from the TransactionProcessingServices.
        private void InitializeTransactionProcessingListView()
        {
            var transactions = TransactionProcessingServices.loadTransactionRequest();
            transactionProcessingListView.Items.Clear();
            // Add each transaction to the ListView
            foreach (var transaction in transactions)
            {
                ListViewItem item = new ListViewItem(new[] { transaction.ProcessId, transaction.AccountId, transaction.Balance.ToString(), transaction.TransactionType, transaction.Amount.ToString(), transaction.ProcessStatus });
                transactionProcessingListView.Items.Add(item);
            }
        }
    }
}
