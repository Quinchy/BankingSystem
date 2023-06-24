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

namespace BankingSystem.Forms.TellerDashBoard.UpdateCards
{
    public partial class UpdateRequestCards : UserControl
    {
        public string InformationType { get; set; }
        public string UpdateId { get; set; }
        public UpdateRequestCards()
        {
            InitializeComponent();
        }
        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (this.InformationType == "Email")
            {
                UpdateRequestServices.ApproveEmailChange(this.UpdateId);
            }
            if (this.InformationType == "Phone Number")
            {
                UpdateRequestServices.ApprovePhoneNumberChange(this.UpdateId);
            }
            if (this.InformationType == "Password")
            {
                UpdateRequestServices.ApprovePasswordChange(this.UpdateId);
            }
            (this.ParentForm as UpdateRequestForm).InitializeUpdateRequestCards();
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            UpdateRequestServices.RejectUpdate(this.UpdateId);
            (this.ParentForm as UpdateRequestForm).InitializeUpdateRequestCards();
        }
    }
}
