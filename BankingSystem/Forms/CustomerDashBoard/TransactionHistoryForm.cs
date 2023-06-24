using BankingSystem.Forms.CustomerDashBoard.TransactionReceipt;
using BankingSystem.Forms.TellerDashBoard.AccountCards;
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

namespace BankingSystem.Forms.CustomerDashBoard
{
    public partial class TransactionHistoryForm : Form
    {
        private string email;
        private int currentPage = 1;
        private int totalRecords = 0;
        private int recordsPerPage = 6;
        private int totalPages => (totalRecords + recordsPerPage - 1) / recordsPerPage;
        public TransactionHistoryForm(string email)
        {
            this.email = email;
            InitializeComponent();
            InitializeTransactionCards();
        }
        private void InitializeTransactionCards()
        {
            // Clear existing controls        
            transactionHistoryFlowPanel.Controls.Clear();
            totalRecords = TransactionHistoryServices.GetTransactionCount(email); // Method to get count of all records
            var transactions = TransactionHistoryServices.RetrieveTransactions(email, recordsPerPage, (currentPage - 1) * recordsPerPage);
            foreach (var transaction in transactions)
            {
                // Create a new card for this transaction
                TransactionCard card = new TransactionCard();
                // Set the labels on the card using the transaction data
                card.transactionType.Text = transaction.TransactionType;
                card.amount.Text = "₱ " + transaction.Amount.ToString();
                card.date.Text = transaction.Date.ToShortDateString();
                card.TransactionId = transaction.TransactionId; // Set TransactionId for this card
                                                                // Generate receipt for this transaction
                TransactionHistoryServices.GenerateReceiptForTransaction(transaction);
                // Depending on your transactionType, you can change the transactionPicture
                if (card.transactionType.Text == "Withdraw")
                {
                    card.transactionPicture.BackgroundImage = Properties.Resources.withdraw;
                }
                else if (card.transactionType.Text == "Deposit")
                {
                    card.transactionPicture.BackgroundImage = Properties.Resources.deposit;
                }
                else if (card.transactionType.Text == "Transfer")
                {
                    card.transactionPicture.BackgroundImage = Properties.Resources.transfer;
                }
                // Add the card to the panel
                transactionHistoryFlowPanel.Controls.Add(card);
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
                InitializeTransactionCards();
            }
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                InitializeTransactionCards();
            }
        }
    }
}
