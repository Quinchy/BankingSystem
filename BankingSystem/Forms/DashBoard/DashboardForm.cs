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
        Control baseFormPanel = BaseForm.GetContentPanel();
        public DashboardForm()
        {
            InitializeComponent();
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
        private void homeButton_Click(object sender, EventArgs e)
        {
            HomeScreenForm homeScreenForm = new HomeScreenForm();
            ChangeDashboardForm(homeScreenForm);
        }
        private void userButton_Click(object sender, EventArgs e)
        {
            UserProfileForm userProfileForm = new UserProfileForm();
            ChangeDashboardForm(userProfileForm);
        }

        private void homeScreenButton_Click(object sender, EventArgs e)
        {
            HomeScreenForm homeScreenForm = new HomeScreenForm();
            ChangeDashboardForm(homeScreenForm);
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            UserProfileForm userProfileForm = new UserProfileForm();
            ChangeDashboardForm(userProfileForm);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Form loginForm = new LoginForm();
            Helpers.ChangeScreen(baseFormPanel, loginForm);
        }
    }
}
