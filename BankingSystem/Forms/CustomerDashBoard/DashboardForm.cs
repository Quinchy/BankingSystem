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
        public DashboardForm(string email)
        {
            this.email = email;
            InitializeComponent();
            InitializeHomeScreen(email);
        }
        // Changes the current form displayed in the dashboard panel.
        private static void ChangeDashboardForm(Form newForm)
        {
            foreach (Control control in dashboardPanel.Controls)
            {
                if (control is Form form)
                {
                    form.Dispose(); // Dispose the form
                }
            }
            dashboardPanel.Controls.Clear();
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            dashboardPanel.Controls.Add(newForm);
            newForm.Show();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        // Handles the Click event of the home screen button.
        // Changes the form displayed in the dashboard panel to the home screen form.
        private void homeScreenButton_Click(object sender, EventArgs e)
        {           
            var   homeScreenForm = new HomeScreenForm(email);
            ChangeDashboardForm(homeScreenForm);
            // Change the button colors to indicate the active screen
            homeScreenButton.ButtonColor = Color.FromArgb(92, 184, 92);
            homeScreenButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            accountButton.ButtonColor = Color.FromArgb(48, 46, 65);
            accountButton.OnHoverButtonColor = Color.FromArgb(65, 64, 89);
        }
        // Handles the Click event of the account button.
        // Changes the form displayed in the dashboard panel to the customer profile form.
        private void accountButton_Click(object sender, EventArgs e)
        {
            var  customerProfileForm = new CustomerProfileForm(email);
            ChangeDashboardForm(customerProfileForm);
            // Change the button colors to indicate the active screen
            accountButton.ButtonColor = Color.FromArgb(92, 184, 92);
            accountButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            homeScreenButton.ButtonColor = Color.FromArgb(48, 46, 65);
            homeScreenButton.OnHoverButtonColor = Color.FromArgb(65, 64, 89);
        }
        // Handles the Click event of the logout button.
        // Changes the screen to the login form.
        private void logoutButton_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            Helpers.changeScreen(baseFormPanel, loginForm);
        }
        // Initializes the home screen with the given email.
        // Change the displayed form to the home screen form
        public void InitializeHomeScreen(string email)
        {
            var homeScreenForm = new HomeScreenForm(email);
            ChangeDashboardForm(homeScreenForm);
        }
    }
}