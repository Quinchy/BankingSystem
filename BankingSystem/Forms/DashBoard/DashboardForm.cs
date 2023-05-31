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

namespace BankingSystem.Forms.DashBoard
{
    public partial class DashboardForm : Form
    {
        private string email;
        Control baseFormPanel = BaseForm.GetContentPanel();
        public DashboardForm(string email)
        {
            InitializeComponent();
            this.email = email;
            HomeScreenForm homeScreenForm = new HomeScreenForm(email);
            dashboardPanel.Controls.Clear();
            homeScreenForm.TopLevel = false;
            homeScreenForm.FormBorderStyle = FormBorderStyle.None;
            homeScreenForm.Dock = DockStyle.Fill;
            dashboardPanel.Controls.Add(homeScreenForm);
            homeScreenForm.Show();
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
            HomeScreenForm homeScreenForm = new HomeScreenForm(email);
            ChangeDashboardForm(homeScreenForm);
            homeScreenButton.ButtonColor = Color.FromArgb(92, 184, 92);
            homeScreenButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            accountButton.ButtonColor = Color.FromArgb(38, 38, 41);
            accountButton.OnHoverButtonColor = Color.FromArgb(48, 48, 51);
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            CustomerProfileForm customerProfileForm = new CustomerProfileForm(email);
            ChangeDashboardForm(customerProfileForm);
            accountButton.ButtonColor = Color.FromArgb(92, 184, 92);
            accountButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            homeScreenButton.ButtonColor = Color.FromArgb(38, 38, 41);
            homeScreenButton.OnHoverButtonColor = Color.FromArgb(48, 48, 51);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Form loginForm = new LoginForm();
            Helpers.changeScreen(baseFormPanel, loginForm);
        }
    }
}
