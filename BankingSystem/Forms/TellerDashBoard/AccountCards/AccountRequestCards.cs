using BankingSystem.Services.TellerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSystem.Forms.TellerDashBoard.AccountCards
{
    public partial class AccountRequestCards : UserControl
    {
        public string RequestId { get; set; }
        public AccountRequestCards()
        {
            InitializeComponent();
        }
        private void acceptButton_Click(object sender, EventArgs e)
        {
            AccountManagementServices.ApproveAccount(this.RequestId);
            (this.ParentForm as AccountManagementForm).InitializeRequestCards();
        }
        private void rejectButton_Click(object sender, EventArgs e)
        {
            AccountManagementServices.RejectAccount(this.RequestId);
            (this.ParentForm as AccountManagementForm).InitializeRequestCards();
        }
    }
}
