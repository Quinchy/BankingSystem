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
        private void approveButton_Click(object sender, EventArgs e)
        {
            if (transactionProcessingListView.CheckedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in transactionProcessingListView.CheckedItems)
                {
                    string processId = selectedItem.SubItems[0].Text;
                    string transactionType = selectedItem.SubItems[3].Text;
                    try
                    {
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
                InitializeTransactionProcessingListView();
            }
            else
            {
                MessageBox.Show("Please check a transaction to approve.");
            }
        }
        private void rejectButton_Click(object sender, EventArgs e)
        {
            if (transactionProcessingListView.CheckedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in transactionProcessingListView.CheckedItems)
                {
                    string processId = selectedItem.SubItems[0].Text;
                    try
                    {
                        TransactionProcessingServices.rejectTransaction(processId);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                InitializeTransactionProcessingListView();
            }
            else
            {
                MessageBox.Show("Please check a transaction to reject.");
            }
        }
        private void InitializeTransactionProcessingListView()
        {
            var transactions = TransactionProcessingServices.loadTransactionRequest();
            transactionProcessingListView.Items.Clear();
            foreach (var transaction in transactions)
            {
                ListViewItem item = new ListViewItem(new[] { transaction.ProcessId, transaction.AccountId, transaction.Balance.ToString(), transaction.TransactionType, transaction.Amount.ToString(), transaction.ProcessStatus });
                transactionProcessingListView.Items.Add(item);
            }
        }
    }
}
