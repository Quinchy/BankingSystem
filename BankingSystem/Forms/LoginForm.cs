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
            // Check if email and password fields are not empty
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill out both the email and password fields.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Call the Authenticate user function to check if the user logging in is in database.
            int result = LoginServices.authenticateUser(email, password);
            if (result == 1)
            {
                // If both email and password are correct then Change the screen to Dashboard.
                Form dashboardForm = new DashBoard.DashboardForm(email);
                Helpers.changeScreen(baseFormPanel, dashboardForm);
            }
            else if (result == 0)
            {
                // Password is incorrect
                MessageBox.Show("Incorrect password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
