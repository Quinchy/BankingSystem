using BankingSystem.Forms.CustomerDashBoard.TransactionReceipt;
using BankingSystem.Models;
using BankingSystem.Models.TellerModels;
using BankingSystem.Services;
using BankingSystem.Services.CustomerServices;
using BankingSystem.Services.TellerServices;
using BankingSystem.Forms.TellerDashBoard.AccountCards;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BankingSystem.Forms.TellerDashBoard
{
    public partial class AccountManagementForm : Form
    {
        private int currentPage = 1;
        private int totalRecords = 0;
        private int recordsPerPage = 6;
        private int totalPages => (totalRecords + recordsPerPage - 1) / recordsPerPage;
        public AccountManagementForm()
        {
            InitializeComponent();
            InitializeRequestCards();
        }
        public void InitializeRequestCards()
        {
            // Clear existing controls        
            accountFlowPanel.Controls.Clear();
            totalRecords = AccountManagementServices.RetrieveTotalAccountRequests();
            var requests = AccountManagementServices.RetrieveAccountRequests(6, (currentPage - 1) * 6);
            foreach (var request in requests)
            {
                // Create a new card for this request
                AccountRequestCards card = new AccountRequestCards();
                // Set the labels on the card using the request data
                card.dateValueLabel.Text = request.RequestDate.ToShortDateString();
                card.statusValueLabel.Text = request.RequestStatus;
                card.emailValueLabel.Text = request.Email;
                card.lastNameValueLabel.Text = request.LastName;
                card.firstNameValueLabel.Text = request.FirstName;
                card.passwordValueLabel.Text = request.Password;
                card.phoneValueLabel.Text = request.PhoneNumber;
                card.RequestId = request.RequestId;
                // Add the card to the panel
                accountFlowPanel.Controls.Add(card);
            }
            // Updating the pageCountLabel as per the current page and total number of pages
            pageCountLabel.Text = $"Page {currentPage} of {totalPages}";
            // Update state of Previous and Next buttons
            UpdatePaginationButtons();
        }
        public void InitializeAccountListCards()
        {
            // Clear existing controls        
            accountFlowPanel.Controls.Clear();
            totalRecords = AccountManagementServices.RetrieveTotalAccountLists();
            var accounts = AccountManagementServices.RetrieveAccountLists(6, (currentPage - 1) * 6);
            foreach (var account in accounts)
            {
                // Create a new card for this request
                AccountListCards card = new AccountListCards();
                // Set the labels on the card using the account data
                card.firstNameValueLabel.Text = account.FirstName;
                card.lastNameValueLabel.Text = account.LastName;
                card.emailValueLabel.Text = account.Email;
                card.phoneValueLabel.Text = account.PhoneNumber;
                card.passwordValueLabel.Text = account.Password;
                card.statusValueLabel.Text = account.AccountStatus;
                card.accountIdValueLabel.Text = account.AccountId;
                card.balanceValueLabel.Text = "₱ " + account.Balance.ToString();

                // Add the card to the panel
                accountFlowPanel.Controls.Add(card);
            }
            // Updating the pageCountLabel as per the current page and total number of pages
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
                InitializeRequestCards();
            }
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                InitializeRequestCards();
            }
        }
        private void accountRequestButton_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            InitializeRequestCards();
            accountRequestButton.ForeColor = Color.FromArgb(92, 184, 92);
            accountListButton.ForeColor = Color.FromArgb(34, 33, 46);
        }

        private void accountListButton_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            InitializeAccountListCards();
            accountRequestButton.ForeColor = Color.FromArgb(34, 33, 46);
            accountListButton.ForeColor = Color.FromArgb(92, 184, 92);
        }
    }
}