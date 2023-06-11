using BankingSystem.Services.CustomerServices;
using BankingSystem.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSystem.Forms
{
    public partial class LoginForm : Form
    {
        Control baseFormPanel = BaseForm.GetContentPanel();
        static CustomerDashBoard.DashboardForm customerDashboardForm;
        static TellerDashBoard.DashboardForm tellerDashboardForm = new TellerDashBoard.DashboardForm();
        static RegistrationForm registrationForm = new RegistrationForm();
        static ForgetPasswordForm forgetPasswordForm = new ForgetPasswordForm();
        public LoginForm()
        {
            InitializeComponent();
        }
        // Handles the Click event of the login button.
        // Retrieves the email and password, validates the input, authenticates the user, and navigates to the correct form.
        private void loginButton_Click(object sender, EventArgs e)
        {
            // Get the email and password from the TextBox
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;
            // Check if email and password fields are not empty
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                ShowMessageBox("Please fill out both the email and password fields.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Check if the user is an admin (teller)
            if (email == "admin" && password == "admin")
            {
                // Change the screen to Teller Dashboard
                Helpers.changeScreen(baseFormPanel, tellerDashboardForm);
                return;
            }
            // Call the Authenticate user function to check if the user logging in is in database.
            int result = LoginServices.authenticateUser(email, password);
            switch (result)
            {
                case 1:
                    // If both email and password are correct then Change the screen to Dashboard.
                    customerDashboardForm = new CustomerDashBoard.DashboardForm(email);                  
                    Helpers.changeScreen(baseFormPanel, customerDashboardForm);
                    break;
                case -2:
                    // Password is incorrect
                    ShowMessageBox("Incorrect password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case -3:
                    // Account is closed
                    ShowMessageBox("Your account is closed. Please contact the bank for further assistance.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case -4:
                    // Account request is pending
                    ShowMessageBox("Your request for opening an account is currently under review. Please wait for confirmation.", "Login Pending", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case -5:
                    // Account request is rejected
                    ShowMessageBox("Your request for opening an account has been rejected. Please contact the bank for further assistance.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    // Email doesn't exist
                    ShowMessageBox("The provided email doesn't exist in our database. Please register first.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
        // Handles the LinkClicked event of the createAccountLinkLabel.
        // Changes the screen to the registration form.
        private void createAccountLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Change the screen to Registration.
            Helpers.changeScreen(baseFormPanel, registrationForm);
        }
        // Handles the CheckedChanged event of the showPasswordCheckbox.
        // Toggles the visibility of the password in the password text box.
        private void showPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !showPasswordCheckbox.Checked;
        }
        // Handles the LinkClicked event of the forgetPasswordLinkLabel.
        // Changes the screen to the forget password form.
        private void forgetPasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Change the screen to Forget Password Form.
            Helpers.changeScreen(baseFormPanel, forgetPasswordForm);
        }
        // Displays a message box with the specified message, title, buttons, and icon.
        private void ShowMessageBox(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, buttons, icon);
        }
    }
}