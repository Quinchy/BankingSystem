using BankingSystem.Database;
using BankingSystem.Models.CustomerModels;
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
            this.email = email;
            InitializeComponent();
            InitializeAccountInformation(email);
        }
        // Handles the Click event of the deposit button.
        // Validates the input, checks if the account belongs to the user, and sends a deposit request.
        private void depositButton_Click(object sender, EventArgs e)
        {
            string accountId = yourIDTransactionTextBox.Text;
            double depositAmount = double.Parse(amountTransactionNumeric.Text);
            // If the account ID is empty or the deposit amount is 0.00
            if (string.IsNullOrEmpty(accountId) || amountTransactionNumeric.Text == "0.00")
            {
                ShowMessageBox("Please fill up both the Account ID and Amount fields.");
                return; // Exit the method
            }
            // If the account ID does not belong to the user
            if (!BankingServices.isTheirAccount(email, accountId))
            {
                ShowMessageBox("This is not your account ID.");
                return; // Exit the method
            }
            // Check if there are any pending requests
            if (BankingServices.checkPendingRequests(email))
            {
                ShowMessageBox("You have a pending request. You cannot perform another transaction until your pending request has been dealt with.");
                return; // Exit the method
            }
            // Ask the user to confirm the deposit
            var confirmResult = MessageBox.Show("Are you sure to deposit this amount?", "Confirm Deposit!", MessageBoxButtons.YesNo);
            // If the user confirms the deposit
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    // Send a deposit request
                    BankingServices.requestDeposit(accountId, depositAmount);
                    ShowMessageBox("Your deposit request has been sent to the teller for review.");
                }
                catch (Exception ex)
                {
                    ShowMessageBox(ex.Message);
                }
            }
        }
        // Handles the Click event of the withdraw button.
        // Validates the input, checks if the account belongs to the user, and sends a withdraw request.
        private void withdrawButton_Click(object sender, EventArgs e)
        {
            string accountId = yourIDTransactionTextBox.Text;
            double withdrawAmount = double.Parse(amountTransactionNumeric.Text);
            // If the account ID is empty or the withdraw amount is 0.00
            if (string.IsNullOrEmpty(accountId) || amountTransactionNumeric.Text == "0.00")
            {
                ShowMessageBox("Please fill up both the Account ID and Amount fields.");
                return; // Exit the method
            }
            // If the account ID does not belong to the user
            if (!BankingServices.isTheirAccount(email, accountId))
            {
                ShowMessageBox("This is not your account ID.");
                return; // Exit the method
            }
            // Check if the withdraw amount is greater than the account balance
            double balance = BankingServices.retrieveAccountBalance(email);
            if (withdrawAmount > balance)
            {
                ShowMessageBox("Insufficient balance.");
                return; // Exit the method
            }
            // Check if there are any pending requests
            if (BankingServices.checkPendingRequests(email))
            {
                ShowMessageBox("You have a pending request. You cannot perform another transaction until your pending request has been dealt with.");
                return; // Exit the method
            }
            // Ask the user to confirm the withdraw
            var confirmResult = MessageBox.Show("Are you sure to withdraw this amount?", "Confirm Withdraw!", MessageBoxButtons.YesNo);
            // If the user confirms the withdraw
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    // Send a withdraw request
                    BankingServices.requestWithdraw(accountId, withdrawAmount);
                    ShowMessageBox("Your withdraw request has been sent to the teller for review.");
                }
                catch (Exception ex)
                {
                    ShowMessageBox(ex.Message);
                }
            }
        }
        // Handles the Click event of the confirm button.
        // Validates the input, checks if the account belongs to the user, checks if the receiver account exists, checks if the balance is sufficient, and sends a transfer request.
        private void confirmButton_Click(object sender, EventArgs e)
        {
            string senderAccountId = yourIDTextBox.Text;
            string receiverAccountId = receiverIDTextBox.Text;
            double transferAmount = double.Parse(amountTransferNumeric.Text);
            // If the sender account ID, receiver account ID, or transfer amount is empty
            if (string.IsNullOrEmpty(senderAccountId) || string.IsNullOrEmpty(receiverAccountId) ||
                amountTransferNumeric.Text == "0.00")
            {
                ShowMessageBox("Please fill up the Sender Account ID, Receiver Account ID and Amount fields.");
                return; // Exit the method
            }
            // If the sender account ID does not belong to the user
            if (!BankingServices.isTheirAccount(email, senderAccountId))
            {
                ShowMessageBox("This is not your account ID.");
                return; // Exit the method
            }
            // If the sender account ID is the same as the receiver account ID
            if (senderAccountId == receiverAccountId)
            {
                ShowMessageBox("You cannot send money to your own account.");
                return; // Exit the method
            }
            // If the receiver account ID does not exist
            if (!BankingServices.isReceiverIDExist(receiverAccountId))
            {
                ShowMessageBox("The receiver account ID does not exist.");
                return; // Exit the method
            }
            // If the balance is less than the transfer amount
            double balance = BankingServices.retrieveAccountBalance(email);
            if (transferAmount > balance)
            {
                ShowMessageBox("Insufficient balance.");
                return; // Exit the method
            }
            // Check if there are any pending requests
            if (BankingServices.checkPendingRequests(email))
            {
                ShowMessageBox("You have a pending request. You cannot perform another transaction until your pending request has been dealt with.");
                return; // Exit the method
            }
            // Ask the user to confirm the transfer
            var confirmResult = MessageBox.Show("Are you sure to transfer this amount?", "Confirm Transfer!", MessageBoxButtons.YesNo);
            // If the user confirms the transfer
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    // Send a transfer request
                    BankingServices.requestTransfer(senderAccountId, receiverAccountId, transferAmount);
                    ShowMessageBox("Your transfer request has been sent to the teller for review.");
                }
                catch (Exception ex)
                {
                    ShowMessageBox(ex.Message);
                }
            }
        }
        // Retrieves and displays the account information and transaction history of the user.
        public static void InitializeAccountInformation(string email)
        {
            // Retrieve the customer's first name, account balance, and transaction history
            string customerFirstName = BankingServices.retrieveCustomerFirstName(email);
            double accountBalance = BankingServices.retrieveAccountBalance(email);
            // Set the account balance and greet the user with their first name
            balanceLabel.Text = "₱ " + accountBalance;
            greetUserLabel.Text = "Welcome, " + customerFirstName;
        }
        // Displays a message box with the specified message.
        private void ShowMessageBox(string message)
        {
            MessageBox.Show(message);
        }
    }
}
