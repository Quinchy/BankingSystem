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
            // Retrieve the account ID associated with the email
            string accountId = Helpers.GetAccountIdByEmail(CurrentUser.Email);

            Receipt receipt = Helpers.GetReceiptFromDatabase(this.TransactionId);

            // Create a new ReceiptCard
            ReceiptCard receiptCard = new ReceiptCard();

            // Check if the sender account ID matches the retrieved account ID
            if (receipt.SenderAccountID != accountId)
            {
                receiptCard.accountIdLabel.Text = "# " + receipt.ReceiverAccountID;
            }
            else
            {
                receiptCard.accountIdLabel.Text = "# " + receipt.SenderAccountID;
            }

            // Fill the ReceiptCard labels with receipt data
            receiptCard.transactionTypeLabel.Text = GetReceiptTitle(receipt.TransactionType);
            receiptCard.transactionAmountLabel.Text = "₱ " + receipt.Amount.ToString();
            receiptCard.transactionReferenceNumberLabel.Text = receipt.ReferenceNumber;
            receiptCard.transactionDateLabel.Text = receipt.TransactionDate.ToShortDateString();

            if (receipt.TransactionType == "Withdraw" || receipt.TransactionType == "Deposit")
            {
                receiptCard.senderName.Text = "Name:";
                receiptCard.senderNameValue.Text = receipt.SenderFullName;
                receiptCard.receiverName.Visible = false;
                receiptCard.receiverNameValue.Visible = false;
            }
            else if (receipt.TransactionType == "Transfer")
            {
                receiptCard.senderNameValue.Text = receipt.SenderFullName;
                receiptCard.receiverNameValue.Text = receipt.ReceiverFullName;
            }
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
