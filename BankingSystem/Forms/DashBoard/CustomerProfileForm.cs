using BankingSystem.Models;
using BankingSystem.Services;
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
    public partial class CustomerProfileForm : Form
    {
        public CustomerProfileForm(string email)
        {
            InitializeComponent();
            // Load the customer's and account's information.
            var result = CustomerServices.loadCustomerInformation(email);
            Customer customer = result.Item1;
            Account account = result.Item2;
            // Set the customer information to the TextBox.
            accountIDTextBox.Text = account.AccountId;
            firstNameTextBox.Text = customer.FirstName;
            lastNameTextBox.Text = customer.LastName;
            emailTextBox.Text = customer.Email;
            phoneNumberTextBox.Text = customer.PhoneNumber;
            passwordTextBox.Text = customer.Password;
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
    }
}
