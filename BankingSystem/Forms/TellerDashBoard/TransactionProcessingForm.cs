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
        public TransactionProcessingForm(string email)
        {
            InitializeComponent();
            TransactionProcessingServices.loadTransactionRequest(transactionProcessingListView);
        }

        private void approveButton_Click(object sender, EventArgs e)
        {
            if (transactionProcessingListView.CheckedItems.Count > 0)
            {
                ListViewItem selectedItem = transactionProcessingListView.CheckedItems[0];
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
                    transactionProcessingListView.Items.Remove(selectedItem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please check a transaction to approve.");
            }
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {

        }
    }
}
