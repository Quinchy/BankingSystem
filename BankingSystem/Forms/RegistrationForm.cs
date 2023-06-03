using BankingSystem.Models;
using BankingSystem.Services;
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
        private void submitButton_Click(object sender, EventArgs e)
        {
            // Check if the password and confirmation password match
            if (!RegistrationServices.IsPasswordMatch(passwordTextBox.Text, confirmPasswordTextBox.Text))
            {
                MessageBox.Show("The password and confirmation password do not match. Please try again.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Create a new Customer Object
            Customer newCustomer = new Customer(
                firstNameTextBox.Text,
                lastNameTextBox.Text,
                emailTextBox.Text,
                phoneNumberTextBox.Text,
                passwordTextBox.Text
            );
            // Validate the customer data
            if (!RegistrationServices.IsValidCustomer(newCustomer))
            {
                MessageBox.Show("All fields must be filled out.", "Invalid Customer Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Call the RegisterUser function to put the Customer into the database.
            RegistrationServices.registerUser(newCustomer);
            // Change the screen to Login.
            Form loginForm = new LoginForm();
            Helpers.changeScreen(baseFormPanel, loginForm);
        }
        private void showPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckbox.Checked == true)
            {
                passwordTextBox.UseSystemPasswordChar = false;
                confirmPasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
                confirmPasswordTextBox.UseSystemPasswordChar = true;
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            // Change the screen to Login.
            Form loginForm = new LoginForm();
            Helpers.changeScreen(baseFormPanel, loginForm);
        }
    }
}
