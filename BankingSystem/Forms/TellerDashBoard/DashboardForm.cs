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
        static AccountManagementForm accountManagementForm;
        static TransactionProcessingForm transactionProcessingForm;
        public DashboardForm()
        {
            InitializeComponent();
            InitializeAccountManagementForm();
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
        private void accountScreenButton_Click(object sender, EventArgs e)
        {
            if (accountManagementForm == null)
            {
                accountManagementForm = new AccountManagementForm();
            }
            ChangeDashboardForm(accountManagementForm);
            accountScreenButton.ButtonColor = Color.FromArgb(92, 184, 92);
            accountScreenButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            transactionScreenButton.ButtonColor = Color.FromArgb(48, 46, 65);
            transactionScreenButton.OnHoverButtonColor = Color.FromArgb(65, 64, 89);
        }
        private void transactionScreenButton_Click(object sender, EventArgs e)
        {
            if (transactionProcessingForm == null)
            {
                transactionProcessingForm = new TransactionProcessingForm();
            }
            ChangeDashboardForm(transactionProcessingForm);
            transactionScreenButton.ButtonColor = Color.FromArgb(92, 184, 92);
            transactionScreenButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            accountScreenButton.ButtonColor = Color.FromArgb(48, 46, 65);
            accountScreenButton.OnHoverButtonColor = Color.FromArgb(65, 64, 89);
        }
        private void logoutButton_Click(object sender, EventArgs e)
        {
            Form loginForm = new LoginForm();
            Helpers.changeScreen(baseFormPanel, loginForm);
        }
        public static void InitializeAccountManagementForm() 
        {
            AccountManagementForm accountManagementForm = new AccountManagementForm();
            dashboardPanel.Controls.Clear();
            accountManagementForm.TopLevel = false;
            accountManagementForm.FormBorderStyle = FormBorderStyle.None;
            accountManagementForm.Dock = DockStyle.Fill;
            dashboardPanel.Controls.Add(accountManagementForm);
            accountManagementForm.Show();
        }
    }
}
