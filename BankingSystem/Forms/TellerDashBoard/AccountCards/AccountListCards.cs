﻿using BankingSystem.Services.TellerServices;
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
    public partial class AccountListCards : UserControl
    {
        public string AccountId { get; set; }
        public AccountListCards()
        {
            InitializeComponent();
        }
        private void openButton_Click(object sender, EventArgs e)
        {
            AccountManagementServices.openAnAccount(this.AccountId);
            // Assuming InitializeTransactionCards is a method in the parent form
            (this.ParentForm as AccountManagementForm).InitializeAccountListCards();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            AccountManagementServices.closeAnAccount(this.AccountId);
            // Assuming InitializeTransactionCards is a method in the parent form
            (this.ParentForm as AccountManagementForm).InitializeAccountListCards();
        }
    }
}
