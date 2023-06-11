using BankingSystem.Models;
using BankingSystem.Models.TellerModels;
using BankingSystem.Services;
using BankingSystem.Services.TellerServices;
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
        public AccountManagementForm()
        {
            InitializeComponent();
            InitializeAccountRequest();
            InitializeAccountList();
        }
        // Handles the Click event of the approve button.
        // Approves all checked account requests in the ListView.
        private void approveButton_Click(object sender, EventArgs e)
        {
            // Iterate over all checked items in the ListView
            foreach (ListViewItem item in accountManagementListView.CheckedItems)
            {
                // Parse the ID and approve the account
                int requestId = int.Parse(item.SubItems[0].Text);
                AccountManagementServices.approveAccount(requestId);
            }
            // Refresh the account request and account list views
            InitializeAccountRequest();
            InitializeAccountList();
        }
        // Handles the Click event of the reject button.
        // Rejects all checked account requests in the ListView.
        private void rejectButton_Click(object sender, EventArgs e)
        {
            // Iterate over all checked items in the ListView
            foreach (ListViewItem item in accountManagementListView.CheckedItems)
            {
                // Parse the ID and reject the account
                int requestId = int.Parse(item.SubItems[0].Text);
                AccountManagementServices.rejectAccount(requestId);
            }
            // Refresh the account request and account list views
            InitializeAccountRequest();
            InitializeAccountList();
        }
        // Handles the Click event of the open account button.
        // Opens all checked accounts in the ListView.
        private void openAccountButton_Click(object sender, EventArgs e)
        {
            // Iterate over all checked items in the ListView
            foreach (ListViewItem item in accountListView.CheckedItems)
            {
                // Parse the ID and open the account
                string accountId = item.SubItems[0].Text;
                AccountManagementServices.openAnAccount(accountId);
            }
            // Refresh the account list view
            InitializeAccountList();
        }
        // Handles the Click event of the close account button.
        // Closes all checked accounts in the ListView.
        private void closeAccountButton_Click(object sender, EventArgs e)
        {
            // Iterate over all checked items in the ListView
            foreach (ListViewItem item in accountListView.CheckedItems)
            {
                // Parse the ID and close the account
                string accountId = item.SubItems[0].Text;
                AccountManagementServices.closeAnAccount(accountId);
            }
            // Refresh the account list view
            InitializeAccountList();
        }
        // Initializes the account request ListView with data from the AccountManagementServices.
        private void InitializeAccountRequest()
        {
            var accountRequests = AccountManagementServices.loadAccountRequest();
            accountManagementListView.Items.Clear();
            foreach (var request in accountRequests)
            {
                ListViewItem item = new ListViewItem(new[] { request.RequestId, request.CustomerId, request.Email, request.RequestDate.ToString("yyyy-MM-dd"), request.RequestStatus });
                accountManagementListView.Items.Add(item);
            }
        }
        // Initializes the account list ListView with data from the AccountManagementServices.
        private void InitializeAccountList()
        {
            var accounts = AccountManagementServices.loadAccountList();
            accountListView.Items.Clear();
            foreach (var account in accounts)
            {
                ListViewItem item = new ListViewItem(new[] { account.AccountId, account.CustomerId, account.Balance.ToString(), account.AccountStatus });
                accountListView.Items.Add(item);
            }
        }
    }
}