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
        public DashboardForm()
        {
            InitializeComponent();        
            InitializeAccountManagementForm();                        
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
        // Handles the Click event of the account management button.
        private void accountScreenButton_Click(object sender, EventArgs e)
        {
            // Change the displayed form to the account management form.
            var accountManagementForm = new AccountManagementForm();
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
        private void transactionScreenButton_Click(object sender, EventArgs e)
        {
            // Change the displayed form to the transaction processing form.
            var transactionProcessingForm = new TransactionProcessingForm();
            ChangeDashboardForm(transactionProcessingForm);
            // Change the button colors to indicate the active screen
            transactionScreenButton.ButtonColor = Color.FromArgb(92, 184, 92);
            transactionScreenButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            accountScreenButton.ButtonColor = Color.FromArgb(48, 46, 65);
            accountScreenButton.OnHoverButtonColor = Color.FromArgb(65, 64, 89);
            informationUpdateButton.ButtonColor = Color.FromArgb(48, 46, 65);
            informationUpdateButton.OnHoverButtonColor = Color.FromArgb(65, 64, 89);
        }
        // Handles the Click event of the information update button.
        private void informationUpdateButton_Click(object sender, EventArgs e)
        {
            // Change the displayed form to the update requests form
            var updateRequestForm = new UpdateRequestForm();
            ChangeDashboardForm(updateRequestForm);
            // Change the button colors to indicate the active screen
            informationUpdateButton.ButtonColor = Color.FromArgb(92, 184, 92);
            informationUpdateButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            accountScreenButton.ButtonColor = Color.FromArgb(48, 46, 65);
            accountScreenButton.OnHoverButtonColor = Color.FromArgb(65, 64, 89);
            transactionScreenButton.ButtonColor = Color.FromArgb(48, 46, 65);
            transactionScreenButton.OnHoverButtonColor = Color.FromArgb(65, 64, 89);
        }
        // Handles the Click event of the logout button.
        private void logoutButton_Click(object sender, EventArgs e)
        {
            // Change the displayed form to the login form.
            var loginForm = new LoginForm();
            Helpers.changeScreen(baseFormPanel, loginForm);
        }
        // Initializes the account management form.
        public void InitializeAccountManagementForm()
        {
            // Change the displayed form to the home screen form
            var accountManagementForm = new AccountManagementForm();
            ChangeDashboardForm(accountManagementForm);
        }
    }
}
