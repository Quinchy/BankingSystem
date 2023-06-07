using BankingSystem.Models;
using BankingSystem.Services;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BankingSystem.Forms.TellerDashBoard
{
    public partial class AccountManagementForm : Form
    {
        public AccountManagementForm(string email)
        {
            InitializeComponent();
            AccountManagementServices.loadAccountRequest(accountManagementListView);
            AccountManagementServices.loadAccountList(accountListView);
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

            // Refresh both ListViews
            AccountManagementServices.loadAccountRequest(accountManagementListView);
            AccountManagementServices.loadAccountList(accountListView);
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

            // Refresh both ListViews
            AccountManagementServices.loadAccountRequest(accountManagementListView);
            AccountManagementServices.loadAccountList(accountListView);
        }
        private void openAccountButton_Click(object sender, EventArgs e)
        {
            // Iterate over all checked items in the ListView
            foreach (ListViewItem item in accountListView.CheckedItems)
            {
                // Parse the ID and open the account
                int accountId = int.Parse(item.SubItems[0].Text);
                AccountManagementServices.openAnAccount(accountId);
            }

            // Refresh the ListView
            AccountManagementServices.loadAccountList(accountListView);
        }
        private void closeAccountButton_Click(object sender, EventArgs e)
        {
            // Iterate over all checked items in the ListView
            foreach (ListViewItem item in accountListView.CheckedItems)
            {
                // Parse the ID and close the account
                int accountId = int.Parse(item.SubItems[0].Text);
                AccountManagementServices.closeAnAccount(accountId);
            }

            // Refresh the ListView
            AccountManagementServices.loadAccountList(accountListView);
        }

    }
}
