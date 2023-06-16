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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BankingSystem.Forms.CustomerDashBoard
{
    public partial class CustomerUpdateForm : Form
    {
        private string email;
        Control dashboardPanel = DashboardForm.GetContentPanel();
        public CustomerUpdateForm(string accountId, string email)
        {
            this.email = email;
            InitializeComponent();
            InitializeCustomerEmailForm();
        }
        private static void ChangeCustomerUpdateForm(Form newForm)
        {
            foreach (Control control in customerUpdatePanel.Controls)
            {
                if (control is Form form)
                {
                    form.Dispose(); // Dispose the form
                }
            }
            customerUpdatePanel.Controls.Clear();
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            customerUpdatePanel.Controls.Add(newForm);
            newForm.Show();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            // Change the displayed form to the customer profile form
            var customerProfileForm = new CustomerProfileForm(email);
            Helpers.changeScreen(dashboardPanel, customerProfileForm);
        }
        private void phoneNumberUpdateButton_Click(object sender, EventArgs e)
        {
            // Change the displayed form to the customer phone number form
            var customerPhoneNumberForm = new CustomerPhoneNumberForm(email);
            ChangeCustomerUpdateForm(customerPhoneNumberForm);
            // Change the color of links
            emailUpdateButton.ForeColor = Color.FromArgb(34, 33, 46);
            phoneNumberUpdateButton.ForeColor = Color.FromArgb(92, 184, 92);
            passwordUpdateButton.ForeColor = Color.FromArgb(34, 33, 46);
        }
        private void passwordUpdateButton_Click(object sender, EventArgs e)
        {
            // Change the displayed form to the customer password form
            var customerPasswordForm = new CustomerPasswordForm(email);
            ChangeCustomerUpdateForm(customerPasswordForm);
            // Change the color of links
            emailUpdateButton.ForeColor = Color.FromArgb(34, 33, 46);
            phoneNumberUpdateButton.ForeColor = Color.FromArgb(34, 33, 46);
            passwordUpdateButton.ForeColor = Color.FromArgb(92, 184, 92);
        }
        private void emailUpdateButton_Click(object sender, EventArgs e)
        {
            // Change the displayed form to the customer email form
            var customerEmailForm = new CustomerEmailForm(email);
            ChangeCustomerUpdateForm(customerEmailForm);
            // Change the color of links
            emailUpdateButton.ForeColor = Color.FromArgb(92, 184, 92);
            phoneNumberUpdateButton.ForeColor = Color.FromArgb(34, 33, 46);
            passwordUpdateButton.ForeColor = Color.FromArgb(34, 33, 46);
        }
        public void InitializeCustomerEmailForm()
        {
            // Change the displayed form to the customer email form
            var customerEmailForm = new CustomerEmailForm(email);
            ChangeCustomerUpdateForm(customerEmailForm);
        }
    }
}