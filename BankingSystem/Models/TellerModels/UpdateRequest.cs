using System;
using System.Collections.Generic;
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
        // Gets or sets the account ID.
        public string AccountId { get; set; }
        // Gets or sets the information type.
        public string InformationType { get; set; }
        // Gets or sets the changed information.
        public string ChangedInformation { get; set; }
        // Gets or sets the update status.
        public string UpdateStatus { get; set; }
        // Initializes a new instance of the UpdateRequest class.
        public UpdateRequest(string updateId, string accountId, string informationType, string changedInformation, string updateStatus)
        {
            // Set the update ID.
            UpdateId = updateId;
            // Set the account ID.
            AccountId = accountId;
            // Set the information.
            InformationType = informationType;
            // Set the changed information.
            ChangedInformation = changedInformation;
            // Set the update status.
            UpdateStatus = updateStatus;
        }
    }
}
