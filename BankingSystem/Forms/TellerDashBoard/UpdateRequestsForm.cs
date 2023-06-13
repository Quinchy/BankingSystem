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
    public partial class UpdateRequestForm : Form
    {
        public UpdateRequestForm()
        {
            InitializeComponent();
            InitializeUpdateRequestListView();
        }
        // Handles the Click event of the approve button.
        // Approves all checked transactions in the ListView.
        private void approveButton_Click(object sender, EventArgs e)
        {
            // Check if any transactions are selected
            if (updateRequestListView.CheckedItems.Count > 0)
            {
                // Iterate over all checked items in the ListView
                foreach (ListViewItem selectedItem in updateRequestListView.CheckedItems)
                {
                    string updateId = selectedItem.SubItems[0].Text;
                    string informationType = selectedItem.SubItems[2].Text;
                    try
                    {
                        // Approve the transaction.
                        switch (informationType)
                        {
                            case "Email":
                                UpdateRequestServices.approveEmailUpdate(updateId);
                                break;
                            case "Phone Number":
                                UpdateRequestServices.approvePhoneNumberUpdate(updateId);
                                break;
                            case "Password":
                                UpdateRequestServices.approvePasswordUpdate(updateId);
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                // Refresh the update request list view
                InitializeUpdateRequestListView();
            }
            else
            {
                MessageBox.Show("Please check an update to approve.");
            }
        }
        // Handles the Click event of the reject button.
        // Rejects all checked transactions in the ListView.
        private void rejectButton_Click(object sender, EventArgs e)
        {
            // Check if any transactions are selected
            if (updateRequestListView.CheckedItems.Count > 0)
            {
                // Iterate over all checked items in the ListView
                foreach (ListViewItem selectedItem in updateRequestListView.CheckedItems)
                {
                    string updateId = selectedItem.SubItems[0].Text;
                    try
                    {
                        // Reject the transaction.
                        UpdateRequestServices.rejectUpdate(updateId);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                // Refresh the update request list view
                InitializeUpdateRequestListView();
            }
            else
            {
                MessageBox.Show("Please check an update to reject.");
            }
        }
        // Initializes the update request ListView with data from the UpdateRequestServices.
        private void InitializeUpdateRequestListView()
        {
            var transactions = UpdateRequestServices.loadUpdateRequest();
            updateRequestListView.Items.Clear();
            // Add each transaction to the ListView
            foreach (var transaction in transactions)
            {
                ListViewItem item = new ListViewItem(new[] { transaction.UpdateId, transaction.AccountId, transaction.InformationType, transaction.ChangedInformation, transaction.UpdateStatus });
                updateRequestListView.Items.Add(item);
            }
        }
    }
}
