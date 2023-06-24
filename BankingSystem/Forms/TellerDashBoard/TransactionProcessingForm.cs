using BankingSystem.Forms.TellerDashBoard.TransactionCards;
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
        private int currentPage = 1;
        private int totalRecords = 0;
        private int recordsPerPage = 4;
        private int totalPages => (totalRecords + recordsPerPage - 1) / recordsPerPage;
        private bool viewingRequests = true;
        public TransactionProcessingForm()
        {
            InitializeComponent();
            InitializeTransactionRequestCards();
        }
        public void InitializeTransactionRequestCards()
        {
            // Clear existing controls        
            transactionFlowPanel.Controls.Clear();
            totalRecords = TransactionProcessingServices.RetrieveTotalTransactionRequests();
            var transactions = TransactionProcessingServices.RetrieveTransactionRequests(4, (currentPage - 1) * 4);
            foreach (var transaction in transactions)
            {
                // Create a new card for this transaction
                TransactionRequestCards card = new TransactionRequestCards();
                // Update the labels in the card with data from the transaction
                card.senderFullNameValue.Text = transaction.SenderFullName;
                card.senderAccountIdValue.Text = transaction.SenderAccountId;
                card.currentBalanceValue.Text = transaction.CurrentBalance.ToString("N2");
                card.transactionTypeValue.Text = transaction.TransactionType;
                card.amountValue.Text = transaction.Amount.ToString("N2");
                card.transactionStatusValue.Text = transaction.TransactionStatus;
                card.TransactionType = transaction.TransactionType;
                card.ProcessId = transaction.ProcessId;
                if (transaction.TransactionType == "Withdraw" || transaction.TransactionType == "Deposit")
                {
                    card.receiverLabel.Visible = false;
                    card.line2.Visible = false;
                    card.receiverFullNameValue.Visible = false;
                    card.receiverAccountIdValue.Visible = false;
                }
                else
                {
                    card.receiverLabel.Visible = true;
                    card.line2.Visible = true;
                    card.receiverFullNameValue.Visible = true;
                    card.receiverAccountIdValue.Visible = true;
                    card.receiverFullNameValue.Text = transaction.ReceiverFullName;
                    card.receiverAccountIdValue.Text = transaction.ReceiverAccountId;
                }
                if (transaction.TransactionType == "Withdraw")
                {
                    card.transactionRequestPicture.BackgroundImage = Properties.Resources.withdraw1;
                }
                else if (transaction.TransactionType == "Deposit")
                {
                    card.transactionRequestPicture.BackgroundImage = Properties.Resources.deposit1;
                }
                else if (transaction.TransactionType == "Transfer")
                {
                    card.transactionRequestPicture.BackgroundImage = Properties.Resources.transfer1;
                }

                // Add the card to the panel
                transactionFlowPanel.Controls.Add(card);
            }
            // Updating the pageCountLabel as per the current page and total number of pages
            if (totalRecords == 0)
            {
                currentPage = 0;
            }
            pageCountLabel.Text = $"Page {currentPage} of {totalPages}";
            // Update state of Previous and Next buttons
            UpdatePaginationButtons();
        }
        public void InitializeTransactionHistoryCards()
        {
            // Clear existing controls        
            transactionFlowPanel.Controls.Clear();
            totalRecords = TransactionProcessingServices.RetrieveTotalTransactionHistory();
            var histories = TransactionProcessingServices.RetrieveTransactionHistory(4, (currentPage - 1) * 4);
            foreach (var history in histories)
            {
                // Create a new card for this transaction
                TransactionHistoryCards card = new TransactionHistoryCards();

                // Update the labels in the card with data from the history
                card.senderFullNameValue.Text = history.SenderFullName;
                card.senderAccountIdValue.Text = history.SenderAccountId;
                card.transactionTypeValue.Text = history.TransactionType;
                card.transactionDateLabel.Visible = history.ProcessStatus == "Approved";
                card.transactionDateValue.Visible = history.ProcessStatus == "Approved";
                card.transactionDateValue.Text = history.TransactionDate.ToString("dd/MM/yyyy");
                card.TransactionId = history.TransactionId;
                card.viewReceipt.Visible = history.ProcessStatus == "Approved";
                card.amountValue.Text = history.Amount.ToString("N2");
                card.processStatusValue.Text = history.ProcessStatus;
                if (history.TransactionType == "Withdraw" || history.TransactionType == "Deposit")
                {
                    card.receiverLabel.Visible = false;
                    card.line2.Visible = false;
                    card.receiverFullNameValue.Visible = false;
                    card.receiverAccountIdValue.Visible = false;
                }
                else
                {
                    card.receiverLabel.Visible = true;
                    card.line2.Visible = true;
                    card.receiverFullNameValue.Visible = true;
                    card.receiverAccountIdValue.Visible = true;
                    card.receiverFullNameValue.Text = history.ReceiverFullName;
                    card.receiverAccountIdValue.Text = history.ReceiverAccountId;
                }
                if (history.TransactionType == "Withdraw")
                {
                    card.transactionHistoryPicture.BackgroundImage = Properties.Resources.withdraw1;
                }
                else if (history.TransactionType == "Deposit")
                {
                    card.transactionHistoryPicture.BackgroundImage = Properties.Resources.deposit1;
                }
                else if (history.TransactionType == "Transfer")
                {
                    card.transactionHistoryPicture.BackgroundImage = Properties.Resources.transfer1;
                }

                // Add the card to the panel
                transactionFlowPanel.Controls.Add(card);
            }
            // Updating the pageCountLabel as per the current page and total number of pages
            if (totalRecords == 0)
            {
                currentPage = 0;
            }
            pageCountLabel.Text = $"Page {currentPage} of {totalPages}";
            // Update state of Previous and Next buttons
            UpdatePaginationButtons();
        }
        private void UpdatePaginationButtons()
        {
            previousButton.Enabled = currentPage > 1;
            nextButton.Enabled = currentPage < totalPages;
        }
        private void previousButton_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                if (viewingRequests)
                {
                    InitializeTransactionRequestCards();
                }
                else
                {
                    InitializeTransactionHistoryCards();
                }
            }
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                if (viewingRequests)
                {
                    InitializeTransactionRequestCards();
                }
                else
                {
                    InitializeTransactionHistoryCards();
                }
            }
        }
        private void transactionRequestButton_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            viewingRequests = true; 
            InitializeTransactionRequestCards();
            transactionRequestButton.ForeColor = Color.FromArgb(92, 184, 92);
            transactionHistoryButton.ForeColor = Color.FromArgb(34, 33, 46);
        }
        private void transactionHistoryButton_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            viewingRequests = false;
            InitializeTransactionHistoryCards();
            transactionRequestButton.ForeColor = Color.FromArgb(34, 33, 46);
            transactionHistoryButton.ForeColor = Color.FromArgb(92, 184, 92);
        }
    }
}
