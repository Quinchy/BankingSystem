﻿using BankingSystem.Models;
using BankingSystem.Services.CustomerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSystem.Forms.CustomerDashBoard
{
    public partial class CustomerProfileForm : Form
    {
        public CustomerProfileForm(string email)
        {
            InitializeComponent();
            // Load the customer's information.
            Customer currentCustomer = CustomerProfileServices.retrieveCustomerInformation(email);
            // Set the customer information to the TextBox.
            accountIDTextBox.Text = currentCustomer.AccountId;
            firstNameTextBox.Text = currentCustomer.FirstName;
            lastNameTextBox.Text = currentCustomer.LastName;
            emailTextBox.Text = currentCustomer.Email;
            phoneNumberTextBox.Text = currentCustomer.PhoneNumber;
            passwordTextBox.Text = currentCustomer.Password;
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
        private void copyButton_Click(object sender, EventArgs e)
        {
            // Get the text from the accountIDTextBox
            string accountID = accountIDTextBox.Text;
            // Set the text to the clipboard
            Clipboard.SetText(accountID);
        }
    }
}
