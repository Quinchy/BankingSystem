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
            // Create a new Customer Object
            Customer newCustomer = new Customer(
                firstNameTextBox.Text,
                lastNameTextBox.Text,
                emailTextBox.Text,
                phoneNumberTextBox.Text,
                passwordTextBox.Text
            );
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
    }
}
