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
            Account account = BankingServices.loadAccountInformation(email);
            // Set the customer information to the TextBox.
            balanceLabel.Text = "₱ " + Convert.ToString(account.Balance);
        }
    }
}
