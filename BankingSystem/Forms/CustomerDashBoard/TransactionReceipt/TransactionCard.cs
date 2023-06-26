using BankingSystem.Models.CustomerModels;
using BankingSystem.Services.CustomerServices;
using BankingSystem.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace BankingSystem.Forms.CustomerDashBoard.TransactionReceipt
{
    public partial class TransactionCard : UserControl
    {
        public string TransactionId { get; set; }
        public TransactionCard()
        {
            InitializeComponent();
        }

        private void viewReceipt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Receipt receipt = Helpers.GetReceiptFromDatabase(this.TransactionId);

            // Create a new ReceiptCard
            ReceiptCard receiptCard = new ReceiptCard();

            // Fill the ReceiptCard labels with receipt data
            receiptCard.fullNameLabel.Text = receipt.FullName;
            receiptCard.accountIdLabel.Text = "# " + receipt.AccountID;
            receiptCard.transactionTypeLabel.Text = GetReceiptTitle(receipt.TransactionType);
            receiptCard.transactionAmountLabel.Text = "₱ " + receipt.Amount.ToString();
            receiptCard.transactionReferenceNumberLabel.Text = receipt.ReferenceNumber;
            receiptCard.transactionDateLabel.Text = receipt.TransactionDate.ToShortDateString();

            // Show the receipt in a new ReceiptForm
            ReceiptForm receiptForm = new ReceiptForm();
            receiptForm.receiptPanel.Controls.Add(receiptCard);
            receiptForm.StartPosition = FormStartPosition.CenterScreen;
            receiptForm.ShowDialog();
        }
        private string GetReceiptTitle(string transactionType)
        {
            switch (transactionType)
            {
                case "Withdraw":
                    return "Cash Withdrawal";
                case "Deposit":
                    return "Account Deposit";
                case "Transfer":
                    return "Money Transferal";
                default:
                    return "Unknown Transaction";
            }
        }
    }
}
