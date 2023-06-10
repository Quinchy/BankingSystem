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
        private void approveButton_Click(object sender, EventArgs e)
        {
            // Iterate over all checked items in the ListView
            foreach (ListViewItem item in accountManagementListView.CheckedItems)
            {
                // Parse the ID and approve the account
                int requestId = int.Parse(item.SubItems[0].Text);
                AccountManagementServices.approveAccount(requestId);
            }
            InitializeAccountRequest();
            InitializeAccountList();
        }
        private void rejectButton_Click(object sender, EventArgs e)
        {
            // Iterate over all checked items in the ListView
            foreach (ListViewItem item in accountManagementListView.CheckedItems)
            {
                // Parse the ID and reject the account
                int requestId = int.Parse(item.SubItems[0].Text);
                AccountManagementServices.rejectAccount(requestId);
            }
            InitializeAccountRequest();
            InitializeAccountList();
        }
        private void openAccountButton_Click(object sender, EventArgs e)
        {
            // Iterate over all checked items in the ListView
            foreach (ListViewItem item in accountListView.CheckedItems)
            {
                // Parse the ID and open the account
                string accountId = item.SubItems[0].Text;
                AccountManagementServices.openAnAccount(accountId);
            }
            InitializeAccountList();
        }
        private void closeAccountButton_Click(object sender, EventArgs e)
        {
            // Iterate over all checked items in the ListView
            foreach (ListViewItem item in accountListView.CheckedItems)
            {
                // Parse the ID and close the account
                string accountId = item.SubItems[0].Text;
                AccountManagementServices.closeAnAccount(accountId);
            }
            InitializeAccountList();
        }
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