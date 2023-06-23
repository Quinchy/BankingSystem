using BankingSystem.Models.CustomerModels;
using BankingSystem.Services.CustomerServices;
using BankingSystem.Utils;
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
    public partial class CustomerProfileForm : Form
    {
        private string email;
        Control dashboardPanel = DashboardForm.GetContentPanel();
        public CustomerProfileForm(string email)
        {
            this.email = email;
            InitializeComponent();
            InitializeCustomerProfile(email);
        }
        // Handles the CheckedChanged event of the showPasswordCheckbox.
        // Toggles the visibility of the password in the password text box.
        private void showPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !showPasswordCheckbox.Checked;
        }
        // Handles the Click event of the copyButton.
        // Copies the text from the accountIDTextBox to the clipboard.
        private void copyButton_Click(object sender, EventArgs e)
        {
            // Get the text from the accountIDTextBox
            string accountID = accountIDTextBox.Text;
            // Set the text to the clipboard
            Clipboard.SetText(accountID);
        }
        private void requestButton_Click(object sender, EventArgs e)
        {
            var customerUpdateForm = new CustomerUpdateForm(accountIDTextBox.Text, email);
            Helpers.changeScreen(dashboardPanel, customerUpdateForm);
        }
        private void InitializeCustomerProfile(string email)
        {
            // Load the customer's information.
            Customer currentCustomer = CustomerProfileServices.retrieveCustomerInformation(email);
            // Set the customer information to the TextBox.
            accountIDTextBox.Text = currentCustomer.AccountId;
            firstNameTextBox.Text = currentCustomer.FirstName;
            lastNameTextBox.Text = currentCustomer.LastName;
            emailTextBox.Text = currentCustomer.Email;
            phoneNumberTextBox.Text = currentCustomer.PhoneNumber;
            passwordTextBox.Text = currentCustomer.Password;
        }
    }
}
