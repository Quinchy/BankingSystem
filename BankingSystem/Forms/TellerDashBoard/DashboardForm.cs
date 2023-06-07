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

namespace BankingSystem.Forms.TellerDashBoard
{
    public partial class DashboardForm : Form
    {
        private string email;
        Control baseFormPanel = BaseForm.GetContentPanel();
        public DashboardForm(string email)
        {
            InitializeComponent();
            this.email = email;
            AccountManagementForm accountManagementForm = new AccountManagementForm(email);
            dashboardPanel.Controls.Clear();
            accountManagementForm.TopLevel = false;
            accountManagementForm.FormBorderStyle = FormBorderStyle.None;
            accountManagementForm.Dock = DockStyle.Fill;
            dashboardPanel.Controls.Add(accountManagementForm);
            accountManagementForm.Show();
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
            AccountManagementForm accountManagementForm = new AccountManagementForm(email);
            ChangeDashboardForm(accountManagementForm);
            accountScreenButton.ButtonColor = Color.FromArgb(92, 184, 92);
            accountScreenButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            transactionScreenButton.ButtonColor = Color.FromArgb(48, 46, 65);
            transactionScreenButton.OnHoverButtonColor = Color.FromArgb(65, 64, 89);
        }

        private void transactionScreenButton_Click(object sender, EventArgs e)
        {
            TransactionProcessingForm transactionProcessingForm = new TransactionProcessingForm(email);
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
    }
}
