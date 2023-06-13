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
    public partial class CustomerPhoneNumberForm : Form
    {
        private string AccountId;
        public CustomerPhoneNumberForm(string accountId)
        {
            InitializeComponent();
            this.AccountId = accountId;
        }

        private void requestButton_Click(object sender, EventArgs e)
        {
            string newPhoneNumber = phoneNumberTextBox.Text;
            // Check if the textbox is empty
            if (string.IsNullOrEmpty(newPhoneNumber))
            {
                // Alert the user to fill up the textbox
                MessageBox.Show("Please enter a phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try 
                {                
                    // Proceed with the request
                    CustomerUpdateServices.requestPhoneNumberUpdate(AccountId, newPhoneNumber);
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
