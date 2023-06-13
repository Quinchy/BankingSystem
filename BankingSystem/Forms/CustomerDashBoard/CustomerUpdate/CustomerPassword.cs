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
    public partial class CustomerPasswordForm : Form
    {
        private string AccountId;
        public CustomerPasswordForm(string accountId)
        {
            InitializeComponent();
            this.AccountId = accountId;
        }

        private void showPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !showPasswordCheckbox.Checked;
        }

        private void requestButton_Click(object sender, EventArgs e)
        {
            string newPassword = passwordTextBox.Text;
            // Check if the textbox is empty
            if (string.IsNullOrEmpty(newPassword))
            {
                // Alert the user to fill up the textbox
                MessageBox.Show("Please enter a password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    // Proceed with the request
                    CustomerUpdateServices.requestPasswordUpdate(AccountId, newPassword);
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
