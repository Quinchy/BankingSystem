using BankingSystem.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BankingSystem.Forms.CustomerDashBoard
{
    public partial class HomeScreenForm : Form
    {
        private string email;
        public HomeScreenForm(string email)
        {
            InitializeComponent();
            this.email = email;
            // Load the customer's information.
            Tuple<Account, List<Transaction>> accountAndTransactions = BankingServices.loadAccountInformation(email);
            string customerFirstName = BankingServices.GetCustomerFirstName(email);
            // Set the customer information to the TextBox.
            balanceLabel.Text = "₱ " + Convert.ToString(accountAndTransactions.Item1.Balance) + ".00";
            // Greet the user with their first name
            greetUserLabel.Text = "Welcome, " + customerFirstName;
            // Load transaction history into ListView
            foreach (Transaction transaction in accountAndTransactions.Item2)
            {
                ListViewItem item = new ListViewItem(transaction.TransactionId);
                item.SubItems.Add(transaction.Amount.ToString());
                item.SubItems.Add(transaction.Date.ToString());
                item.SubItems.Add(transaction.TransactionType);
                transactionHistoryView.Items.Add(item);
            }
        }
        private void depositButton_Click(object sender, EventArgs e)
        {
            string accountId = yourIDTransactionTextBox.Text;
            double depositAmount = double.Parse(amountTransactionNumeric.Text);
            if (string.IsNullOrEmpty(accountId) || amountTransactionNumeric.Text == "0.00")
            {
                MessageBox.Show("Please fill up both the Account ID and Amount fields.");
                return;
            }
            if (!BankingServices.isTheirAccount(email, accountId))
            {
                MessageBox.Show("This is not your account ID.");
                return;
            }
            var confirmResult = MessageBox.Show("Are you sure to deposit this amount?", "Confirm Deposit!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                BankingServices.requestDeposit(accountId, depositAmount);
                MessageBox.Show("Your deposit request has been sent to the teller for review.");
            }
        }
        private void withdrawButton_Click(object sender, EventArgs e)
        {
            string accountId = yourIDTransactionTextBox.Text;
            double withdrawAmount = double.Parse(amountTransactionNumeric.Text);
            if (string.IsNullOrEmpty(accountId) || amountTransactionNumeric.Text == "0.00")
            {
                MessageBox.Show("Please fill up both the Account ID and Amount fields.");
                return;
            }
            if (!BankingServices.isTheirAccount(email, accountId))
            {
                MessageBox.Show("This is not your account ID.");
                return;
            }
            var confirmResult = MessageBox.Show("Are you sure to withdraw this amount?", "Confirm Withdraw!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    BankingServices.requestWithdraw(accountId, withdrawAmount);
                    MessageBox.Show("Your withdraw request has been sent to the teller for review.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void confirmButton_Click(object sender, EventArgs e)
        {
            string senderAccountId = yourIDTextBox.Text;
            string receiverAccountId = receiverIDTextBox.Text;
            double transferAmount = double.Parse(amountTransferNumeric.Text);
            if (string.IsNullOrEmpty(senderAccountId) || string.IsNullOrEmpty(receiverAccountId) ||
                !double.TryParse(amountTransferNumeric.Text, out transferAmount))
            {
                MessageBox.Show("Please fill up the Sender Account ID, Receiver Account ID and Amount fields.");
                return;
            }
            if (!BankingServices.isTheirAccount(email, senderAccountId))
            {
                MessageBox.Show("This is not your account ID.");
                return;
            }
            if (double.Parse(balanceLabel.Text.Substring(2)) < transferAmount)
            {
                MessageBox.Show("Insufficient balance.");
                return;
            }
            var confirmResult = MessageBox.Show("Are you sure to transfer this amount?", "Confirm Transfer!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                BankingServices.transferMoney(senderAccountId, receiverAccountId, transferAmount);
                balanceLabel.Text = "₱ " + (double.Parse(balanceLabel.Text.Substring(2)) - transferAmount).ToString() + ".00";
            }
        }
    }
}
