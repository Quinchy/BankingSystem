using BankingSystem.Services;
using BankingSystem.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSystem.Forms
{
    public partial class LoginForm : Form
    {
        Control baseFormPanel = BaseForm.GetContentPanel();
        public LoginForm()
        {
            InitializeComponent();

        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            // Get the email and password from the TextBox
            String email = emailTextBox.Text;
            String password = passwordTextBox.Text;
            // Call the Authenticate user function to check if the user logging in is in database.
            if (LoginServices.authenticateUser(email, password))
            {
                // If exist then Change the screen to Dashboard.
                Form dashboardForm = new DashBoard.DashboardForm(email);
                Helpers.changeScreen(baseFormPanel, dashboardForm);
            }
            else
            {
                // Show a messagebox that will alert the user to register.
            }
        }
        private void createAccountLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Change the screen to Registration.
            Form registrationForm = new RegistrationForm();
            Helpers.changeScreen(baseFormPanel, registrationForm);
        }
        private void showPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckbox.Checked == true)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void forgetPasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
