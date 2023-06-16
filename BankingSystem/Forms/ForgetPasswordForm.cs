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
    public partial class ForgetPasswordForm : Form
    {
        Control baseFormPanel = BaseForm.GetContentPanel();
        public ForgetPasswordForm()
        {
            InitializeComponent();
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string newPassword = passwordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;

            // Check if all fields are filled up
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill up all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if passwordTextBox and confirmPasswordTextBox are matching
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                // Request a password reset
                ForgetPasswordServices.requestResetPassword(email, newPassword);
                // Alert the user that their request has been sent
                MessageBox.Show("Your password reset request has been sent.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Alert the user about the error
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Handles the Click event of the back button.
        // Changes the screen to the login form.
        private void backButton_Click(object sender, EventArgs e)
        {
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
    }
}
