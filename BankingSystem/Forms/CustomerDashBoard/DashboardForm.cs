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
        LoginForm loginForm = new LoginForm();
        HomeScreenForm homeScreenForm;
        CustomerProfileForm customerProfileForm;
        public DashboardForm(string email)
        {
            this.email = email;
            InitializeComponent();
            InitializeHomeScreen(email);
            if (homeScreenForm == null || customerProfileForm == null)
            {
                homeScreenForm = new HomeScreenForm(email);
                customerProfileForm = new CustomerProfileForm(email);
            }
        }
        // Changes the current form displayed in the dashboard panel.
        private static void ChangeDashboardForm(Form newForm)
        {
            // Clear any existing controls in the dashboard panel
            dashboardPanel.Controls.Clear();
            // Set the new form to be a child form, remove the border, and fill the panel
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            // Add the new form to the dashboard panel and display it
            dashboardPanel.Controls.Add(newForm);
            newForm.Show();
        }
        // Handles the Click event of the home screen button.
        // Changes the form displayed in the dashboard panel to the home screen form.
        private void homeScreenButton_Click(object sender, EventArgs e)
        {           
            if (homeScreenForm == null)
            {
                homeScreenForm = new HomeScreenForm(email);
            }
            // Change the displayed form to the home screen form
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
            // If the customer profile form has not been created yet, create it
            if (customerProfileForm == null)
            {
                customerProfileForm = new CustomerProfileForm(email);
            }
            // Change the displayed form to the customer profile form
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
            Helpers.changeScreen(baseFormPanel, loginForm);
        }
        // Initializes the home screen with the given email.
        public void InitializeHomeScreen(string email)
        {
            // If the home screen form has not been created yet, create it
            if (homeScreenForm == null)
            {
                homeScreenForm = new HomeScreenForm(email);
            }
            // Change the displayed form to the home screen form
            ChangeDashboardForm(homeScreenForm);
        }
    }
}