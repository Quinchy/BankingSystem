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

namespace BankingSystem.Forms
{
    public partial class RegistrationForm : Form
    {
        Control baseFormPanel = BaseForm.GetContentPanel();
        public RegistrationForm()
        {
            InitializeComponent();
        }
        // Handles the click event of the submit button on the registration form.
        private void submitButton_Click(object sender, EventArgs e)
        {
            // Check if the password is at least 8 characters long
            if (passwordTextBox.Text.Length < 8)
            {
                ShowMessageBox("The password is too short. It must be at least 8 characters long.", "Password Too Short", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Check if the password and confirmation password match
            if (!RegistrationServices.IsPasswordMatch(passwordTextBox.Text, confirmPasswordTextBox.Text))
            {
                ShowMessageBox("The password and confirmation password do not match. Please try again.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Create a new Customer Object
            Customer newCustomer = new Customer(
                null,
                firstNameTextBox.Text,
                lastNameTextBox.Text,
                emailTextBox.Text,
                phoneNumberTextBox.Text,
                passwordTextBox.Text
            );
            // Validate the customer data
            if (!RegistrationServices.IsValidCustomer(newCustomer))
            {
                ShowMessageBox("All fields must be filled out.", "Invalid Customer Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Call the RegisterUser function to put the Customer into the database.
            RegistrationServices.registerUser(newCustomer);
            // Change the screen to Login.
            var loginForm = new LoginForm();
            Helpers.changeScreen(baseFormPanel, loginForm);
        }
        // Handles the CheckedChanged event of the showPasswordCheckbox.
        // Toggles the visibility of the password and confirmation password in their respective text boxes.
        private void showPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            bool isPasswordVisible = showPasswordCheckbox.Checked;
            passwordTextBox.UseSystemPasswordChar = !isPasswordVisible;
            confirmPasswordTextBox.UseSystemPasswordChar = !isPasswordVisible;
        }
        // Handles the Click event of the back button.
        // Changes the screen to the login form.
        private void backButton_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            Helpers.changeScreen(baseFormPanel, loginForm);
        }
        // Displays a message box with the specified message, title, buttons, and icon.
        private void ShowMessageBox(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, buttons, icon);
        }
    }
}