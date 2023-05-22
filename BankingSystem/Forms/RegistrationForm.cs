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
    public partial class RegistrationForm : Form
    {
        Control baseFormPanel = BaseForm.GetContentPanel();
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Form dashboardForm = new DashBoard.DashboardForm();
            Helpers.ChangeScreen(baseFormPanel, dashboardForm);
        }
    }
}
