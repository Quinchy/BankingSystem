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

namespace BankingSystem.Forms.CustomerDashBoard
{
    public partial class CustomerUpdateForm : Form
    {
        Control dashboardPanel = DashboardForm.GetContentPanel();
        CustomerProfileForm customerProfileForm;
        public CustomerUpdateForm(string email)
        {
            InitializeComponent();
            customerProfileForm = new CustomerProfileForm(email);
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Helpers.changeScreen(dashboardPanel, customerProfileForm);
        }
    }
}