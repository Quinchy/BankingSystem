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
    public partial class DashboardForm : Form
    {
        private string email;
        Control baseFormPanel = BaseForm.GetContentPanel();
        static HomeScreenForm homeScreenForm;
        static CustomerProfileForm customerProfileForm;
        public DashboardForm(string email)
        {
            this.email = email;
            InitializeComponent();
            InitializeHomeScreen(email);
        }
        private static void ChangeDashboardForm(Form newForm)
        {
            dashboardPanel.Controls.Clear();
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            dashboardPanel.Controls.Add(newForm);
            newForm.Show();
        }
        private void homeScreenButton_Click(object sender, EventArgs e)
        {
            if (homeScreenForm == null)
            {
                homeScreenForm = new HomeScreenForm(email);
            }
            ChangeDashboardForm(homeScreenForm);
            homeScreenButton.ButtonColor = Color.FromArgb(92, 184, 92);
            homeScreenButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            accountButton.ButtonColor = Color.FromArgb(48, 46, 65);
            accountButton.OnHoverButtonColor = Color.FromArgb(65, 64, 89);
        }
        private void accountButton_Click(object sender, EventArgs e)
        {
            if (customerProfileForm == null)
            {
                customerProfileForm = new CustomerProfileForm(email);
            }
            ChangeDashboardForm(customerProfileForm);
            accountButton.ButtonColor = Color.FromArgb(92, 184, 92);
            accountButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            homeScreenButton.ButtonColor = Color.FromArgb(48, 46, 65);
            homeScreenButton.OnHoverButtonColor = Color.FromArgb(65, 64, 89);
        }
        private void logoutButton_Click(object sender, EventArgs e)
        {
            Form loginForm = new LoginForm();
            Helpers.changeScreen(baseFormPanel, loginForm);
        }
        public static void InitializeHomeScreen(string email)
        {
            if (homeScreenForm == null)
            {
                homeScreenForm = new HomeScreenForm(email);
            }
            ChangeDashboardForm(homeScreenForm);
        }
    }
}