using BankingSystem.Services.CustomerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSystem.Forms.CustomerDashBoard.CustomerUpdate
{
    public partial class CustomerEmailForm : Form
    {
        private string AccountId;
        public CustomerEmailForm(string accountId)
        {
            InitializeComponent();
            this.AccountId = accountId;
        }

        private void requestButton_Click(object sender, EventArgs e)
        {
            string newEmail = emailTextBox.Text;
            // Check if the textbox is empty
            if (string.IsNullOrEmpty(newEmail))
            {
                // Alert the user to fill up the textbox
                MessageBox.Show("Please enter an email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    // Proceed with the request
                    CustomerUpdateServices.requestEmailUpdate(AccountId, newEmail);
                    // Alert the user that their request has been sent
                    MessageBox.Show("Your request has been sent.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Show the exception message as an alert
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
