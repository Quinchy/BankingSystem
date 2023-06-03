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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BankingSystem.Forms.DashBoard
{
    public partial class HomeScreenForm : Form
    {
        public HomeScreenForm(string email)
        {
            InitializeComponent();

            // Load the customer's information.
            Tuple<Account, List<Transaction>> accountAndTransactions = BankingServices.loadAccountInformation(email);
            string customerFirstName = BankingServices.GetCustomerFirstName(email);
            // Set the customer information to the TextBox.
            balanceLabel.Text = "₱ " + Convert.ToString(accountAndTransactions.Item1.Balance);
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
    }
}
