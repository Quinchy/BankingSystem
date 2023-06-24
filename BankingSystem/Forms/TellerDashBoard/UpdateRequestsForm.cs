using BankingSystem.Forms.TellerDashBoard.TransactionCards;
using BankingSystem.Forms.TellerDashBoard.UpdateCards;
using BankingSystem.Models;
using BankingSystem.Services.CustomerServices;
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

namespace BankingSystem.Forms.TellerDashBoard
{
    public partial class UpdateRequestForm : Form
    {
        private int currentPage = 1;
        private int totalRecords = 0;
        private int recordsPerPage = 4;
        private int totalPages => (totalRecords + recordsPerPage - 1) / recordsPerPage;
        public UpdateRequestForm()
        {
            InitializeComponent();
            InitializeUpdateRequestCards();
        }
        public void InitializeUpdateRequestCards()
        {
            // Clear existing controls        
            updateFlowPanel.Controls.Clear();
            totalRecords = UpdateRequestServices.RetrieveTotalUpdateRequests();            
            var updates = UpdateRequestServices.RetrieveUpdateRequests(4, (currentPage - 1) * 4);
            foreach (var update in updates) 
            {
                // Create a new card for this transaction
                UpdateRequestCards card = new UpdateRequestCards();
                card.UpdateId = update.UpdateId;
                card.updateStatusValue.Text = update.UpdateStatus;
                card.senderFullNameValue.Text = update.FullName;
                card.senderAccountIdValue.Text = update.AccountId;
                card.InformationType = update.InformationType;
                card.informationTypeValue.Text = update.InformationType;
                card.currentInformationLabel.Text = update.InformationType;
                card.currentInformationValue.Text = update.CurrentInformation;
                card.newInformationLabel.Text = update.InformationType;
                card.newInformationValue.Text = update.ChangedInformation;
                if (update.InformationType == "Email")
                {
                    card.updateRequestPicture.BackgroundImage = Properties.Resources.envelope;
                }
                else if (update.InformationType == "Phone Number")
                {
                    card.updateRequestPicture.BackgroundImage = Properties.Resources.telephone;
                }
                else if (update.InformationType == "Password")
                {
                    card.updateRequestPicture.BackgroundImage = Properties.Resources.locked_computer;
                }
                updateFlowPanel.Controls.Add(card);
            }
            // Updating the pageCountLabel as per the current page and total number of pages
            if (totalRecords == 0)
            {
                currentPage = 0;
            }
            pageCountLabel.Text = $"Page {currentPage} of {totalPages}";
            // Update state of Previous and Next buttons
            UpdatePaginationButtons();
        }
        private void UpdatePaginationButtons()
        {
            previousButton.Enabled = currentPage > 1;
            nextButton.Enabled = currentPage < totalPages;
        }
        private void previousButton_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                InitializeUpdateRequestCards();
            }
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                InitializeUpdateRequestCards();
            }
        }
    }
}
