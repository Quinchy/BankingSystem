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
        LoginForm loginForm;
        public ForgetPasswordForm()
        {
            InitializeComponent();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Change the screen to Login.
            if (loginForm == null)
            {
                loginForm = new LoginForm();
            }
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
    }
}
