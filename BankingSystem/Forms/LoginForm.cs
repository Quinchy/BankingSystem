using BankingSystem.Services.CustomerServices;
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
            // Check if email and password fields are not empty
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill out both the email and password fields.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the user is an admin (teller)
            if (email == "admin" && password == "admin")
            {
                // Change the screen to Teller Dashboard
                Form dashboardForm = new TellerDashBoard.DashboardForm(email);
                Helpers.changeScreen(baseFormPanel, dashboardForm);
                return;
            }

            // Call the Authenticate user function to check if the user logging in is in database.
            int result = LoginServices.authenticateUser(email, password);
            if (result == 1)
            {
                // If both email and password are correct then Change the screen to Dashboard.
                Form dashboardForm = new CustomerDashBoard.DashboardForm(email);
                Helpers.changeScreen(baseFormPanel, dashboardForm);
            }
            else if (result == -2)
            {
                // Password is incorrect
                MessageBox.Show("Incorrect password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result == -3)
            {
                // Account is closed
                MessageBox.Show("Your account is closed. Please contact the bank for further assistance.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result == -4)
            {
                // Account request is pending
                MessageBox.Show("Your request for opening an account is currently under review. Please wait for confirmation.", "Login Pending", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == -5)
            {
                // Account request is rejected
                MessageBox.Show("Your request for opening an account has been rejected. Please contact the bank for further assistance.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Email doesn't exist
                MessageBox.Show("The provided email doesn't exist in our database. Please register first.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Change the screen to Forget Password Form.
            Form forgetPasswordForm = new ForgetPasswordForm();
            Helpers.changeScreen(baseFormPanel, forgetPasswordForm);
        }
    }
}
