using BankingSystem.Forms.CustomerDashBoard.CustomerUpdate;
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
    public partial class CustomerUpdateForm : Form
    {
        Control dashboardPanel = DashboardForm.GetContentPanel();
        CustomerProfileForm customerProfileForm;
        CustomerEmailForm customerEmailForm;
        CustomerPhoneNumberForm customerPhoneNumberForm;
        CustomerPasswordForm customerPasswordForm;
        public CustomerUpdateForm(string accountId, string email)
        {
            InitializeComponent();
            customerEmailForm = new CustomerEmailForm(accountId);
            InitializeCustomerEmailForm();
            customerProfileForm = new CustomerProfileForm(email);
            customerPhoneNumberForm = new CustomerPhoneNumberForm(accountId);
            customerPasswordForm = new CustomerPasswordForm(accountId);
        }
        private static void ChangeCustomerUpdateForm(Form newForm)
        {
            // Clear any existing controls in the dashboard panel
            customerUpdatePanel.Controls.Clear();
            // Set the new form to be a child form, remove the border, and fill the panel
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            // Add the new form to the dashboard panel and display it
            customerUpdatePanel.Controls.Add(newForm);
            newForm.Show();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            // Change the displayed form to the customer profile form
            Helpers.changeScreen(dashboardPanel, customerProfileForm);
        }
        public void InitializeCustomerEmailForm()
        {
            // Change the displayed form to the customer email form
            ChangeCustomerUpdateForm(customerEmailForm);
        }

        private void phoneNumberUpdateButton_Click(object sender, EventArgs e)
        {
            // Change the displayed form to the customer phone number form
            ChangeCustomerUpdateForm(customerPhoneNumberForm);
            // Change the color of links
            emailUpdateButton.ForeColor = Color.FromArgb(34, 33, 46);
            phoneNumberUpdateButton.ForeColor = Color.FromArgb(92, 184, 92);
            passwordUpdateButton.ForeColor = Color.FromArgb(34, 33, 46);
        }

        private void passwordUpdateButton_Click(object sender, EventArgs e)
        {
            // Change the displayed form to the customer password form
            ChangeCustomerUpdateForm(customerPasswordForm);
            // Change the color of links
            emailUpdateButton.ForeColor = Color.FromArgb(34, 33, 46);
            phoneNumberUpdateButton.ForeColor = Color.FromArgb(34, 33, 46);
            passwordUpdateButton.ForeColor = Color.FromArgb(92, 184, 92);
        }

        private void emailUpdateButton_Click(object sender, EventArgs e)
        {
            // Change the displayed form to the customer email form
            ChangeCustomerUpdateForm(customerEmailForm);
            // Change the color of links
            emailUpdateButton.ForeColor = Color.FromArgb(92, 184, 92);
            phoneNumberUpdateButton.ForeColor = Color.FromArgb(34, 33, 46);
            passwordUpdateButton.ForeColor = Color.FromArgb(34, 33, 46);
        }
    }
}