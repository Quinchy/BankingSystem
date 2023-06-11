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
        LoginForm loginForm = new LoginForm();
        public ForgetPasswordForm()
        {
            InitializeComponent();
        }
        private void resetButton_Click(object sender, EventArgs e)
        {

        }
        // Handles the Click event of the back button.
        // Changes the screen to the login form.
        private void backButton_Click(object sender, EventArgs e)
        {
            // Change the screen to Login.
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
