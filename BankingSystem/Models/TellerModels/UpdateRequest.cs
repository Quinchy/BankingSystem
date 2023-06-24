using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Models.TellerModels
{
    // Defines the UpdateRequest class.
    internal class UpdateRequest
    {
        // Gets or sets the update ID.
        public string UpdateId { get; set; }
        // Gets or sets the update status.
        public string UpdateStatus { get; set; }
        // Gets or sets the full name.
        public string FullName { get; set; }
        // Gets or sets the account id.
        public string AccountId { get; set; }
        // Gets or sets the information type.
        public string InformationType { get; set; }
        // Gets or sets the current information.
        public string CurrentInformation { get; set; }
        // Gets or sets the changed information.
        public string ChangedInformation { get; set; }       
        // Initializes a new instance of the UpdateRequest class.
        public UpdateRequest(string updateId, string updateStatus, string fullName, string accountId, string informationType, string currentInformation, string changedInformation)
        {
            // Set the update ID.
            UpdateId = updateId;
            // Set the update status.
            UpdateStatus = updateStatus;
            // Set the full name.
            FullName = fullName;
            // Set the account ID.
            AccountId = accountId;
            // Set the information.
            InformationType = informationType;
            // Set the current information.
            CurrentInformation = currentInformation;
            // Set the changed information.
            ChangedInformation = changedInformation;
        }
    }
}
