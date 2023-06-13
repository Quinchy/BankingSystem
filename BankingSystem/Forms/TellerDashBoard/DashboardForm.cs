using BankingSystem.Forms.CustomerDashBoard;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BankingSystem.Forms.TellerDashBoard
{
    public partial class DashboardForm : Form
    {
        Control baseFormPanel = BaseForm.GetContentPanel();
        LoginForm loginForm;
        AccountManagementForm accountManagementForm;
        TransactionProcessingForm transactionProcessingForm;
        UpdateRequestForm updateRequestForm;
        public DashboardForm()
        {
            InitializeComponent();
            accountManagementForm = new AccountManagementForm();
            InitializeAccountManagementForm();
            loginForm = new LoginForm();
            transactionProcessingForm = new TransactionProcessingForm();
            updateRequestForm = new UpdateRequestForm();
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
        // Handles the Click event of the account management button.
        // Changes the form displayed in the dashboard panel to the account management form.
        private void accountScreenButton_Click(object sender, EventArgs e)
        {
            // Change the displayed form to the account management form.
            ChangeDashboardForm(accountManagementForm);
            // Change the button colors to indicate the active screen
            accountScreenButton.ButtonColor = Color.FromArgb(92, 184, 92);
            accountScreenButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            transactionScreenButton.ButtonColor = Color.FromArgb(48, 46, 65);
            transactionScreenButton.OnHoverButtonColor = Color.FromArgb(65, 64, 89);
            informationUpdateButton.ButtonColor = Color.FromArgb(48, 46, 65);
            informationUpdateButton.OnHoverButtonColor = Color.FromArgb(65, 64, 89);
        }
        // Handles the Click event of the transaction processing button.
        // Changes the form displayed in the dashboard panel to the transaction processing form.
        private void transactionScreenButton_Click(object sender, EventArgs e)
        {
            // Change the displayed form to thetransaction processing form.
            ChangeDashboardForm(transactionProcessingForm);
            // Change the button colors to indicate the active screen
            transactionScreenButton.ButtonColor = Color.FromArgb(92, 184, 92);
            transactionScreenButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            accountScreenButton.ButtonColor = Color.FromArgb(48, 46, 65);
            accountScreenButton.OnHoverButtonColor = Color.FromArgb(65, 64, 89);
            informationUpdateButton.ButtonColor = Color.FromArgb(48, 46, 65);
            informationUpdateButton.OnHoverButtonColor = Color.FromArgb(65, 64, 89);
        }
        // Handles the Click event of the logout button.
        // Changes the screen to the login form.
        private void logoutButton_Click(object sender, EventArgs e)
        {
            Helpers.changeScreen(baseFormPanel, loginForm);
        }
        // Initializes the account management form.
        public void InitializeAccountManagementForm()
        {
            // Change the displayed form to the home screen form
            ChangeDashboardForm(accountManagementForm);
        }

        private void informationUpdateButton_Click(object sender, EventArgs e)
        {
            // Change the displayed form to the update requests form
            ChangeDashboardForm(updateRequestForm);
            // Change the button colors to indicate the active screen
            informationUpdateButton.ButtonColor = Color.FromArgb(92, 184, 92);
            informationUpdateButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            accountScreenButton.ButtonColor = Color.FromArgb(48, 46, 65);
            accountScreenButton.OnHoverButtonColor = Color.FromArgb(65, 64, 89);
            transactionScreenButton.ButtonColor = Color.FromArgb(48, 46, 65);
            transactionScreenButton.OnHoverButtonColor = Color.FromArgb(65, 64, 89);
        }
    }
}
