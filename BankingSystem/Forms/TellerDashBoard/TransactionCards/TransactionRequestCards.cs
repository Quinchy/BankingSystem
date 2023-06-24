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

namespace BankingSystem.Forms.TellerDashBoard.TransactionCards
{
    public partial class TransactionRequestCards : UserControl
    {
        public string TransactionType { get; set; }
        public string ProcessId { get; set; }
        public TransactionRequestCards()
        {
            InitializeComponent();
        }
        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (this.TransactionType == "Withdraw") 
            {            
                TransactionProcessingServices.ApproveWithdraw(this.ProcessId);
            }
            if (this.TransactionType == "Deposit")
            {
                TransactionProcessingServices.ApproveDeposit(this.ProcessId);
            }
            if (this.TransactionType == "Transfer")
            {
                TransactionProcessingServices.ApproveTransfer(this.ProcessId);
            }
            (this.ParentForm as TransactionProcessingForm).InitializeTransactionRequestCards();
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            TransactionProcessingServices.RejectTransaction(this.ProcessId);
            (this.ParentForm as TransactionProcessingForm).InitializeTransactionRequestCards();
        }
    }
}
