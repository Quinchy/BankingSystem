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

namespace BankingSystem.Forms
{
    public partial class LoginForm : Form
    {
        Control baseFormPanel = BaseForm.GetContentPanel();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Form dashboardForm = new DashBoard.DashboardForm();
            Helpers.ChangeScreen(baseFormPanel, dashboardForm);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Form registrationForm = new RegistrationForm();
            Helpers.ChangeScreen(baseFormPanel, registrationForm);
        }
    }
}
