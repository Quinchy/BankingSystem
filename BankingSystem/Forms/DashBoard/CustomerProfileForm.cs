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
            // Load the customer's information.
            Customer customer = CustomerServices.loadCustomerInformation(email);
            // Set the customer information to the TextBox.
            firstNameTextBox.Text = customer.FirstName;
            lastNameTextBox.Text = customer.LastName;
            emailTextBox.Text = customer.Email;
            phoneNumberTextBox.Text = customer.PhoneNumber;
            passwordTextBox.Text = customer.Password;
        }
    }
}
