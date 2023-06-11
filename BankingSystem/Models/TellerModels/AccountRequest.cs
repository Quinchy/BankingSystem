using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Models.TellerModels
{
    // Defines the AccountRequest class.
    internal class AccountRequest
    {
        // Gets or sets the request ID.
        public string RequestId { get; set; }
        // Gets or sets the customer ID.
        public string CustomerId { get; set; }
        // Gets or sets the email.
        public string Email { get; set; }
        // Gets or sets the request date.
        public DateTime RequestDate { get; set; }
        // Gets or sets the request status.
        public string RequestStatus { get; set; }
        // Initializes a new instance of the AccountRequest class.
        public AccountRequest(string requestId, string customerId, string email, DateTime requestDate, string requestStatus)
        {
            // Set the request ID.
            RequestId = requestId;
            // Set the customer ID.
            CustomerId = customerId;
            // Set the email.
            Email = email;
            // Set the request date.
            RequestDate = requestDate;
            // Set the request status.
            RequestStatus = requestStatus;
        }
    }
}
