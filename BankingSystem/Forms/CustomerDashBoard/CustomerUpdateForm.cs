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
        private string email;
        Control dashboardPanel = DashboardForm.GetContentPanel();
        CustomerProfileForm customerProfileForm;
        public CustomerUpdateForm(string email)
        {
            this.email = email;
            InitializeComponent();                 
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            if (customerProfileForm == null) 
            {
                customerProfileForm = new CustomerProfileForm(email);
            }
            Helpers.changeScreen(dashboardPanel, customerProfileForm);
        }
    }
}
