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
        // Gets or sets the first name.
        public string FirstName { get; set; }
        // Gets or sets the last name.
        public string LastName { get; set; }
        // Gets or sets the email.
        public string Email { get; set; }
        // Gets or sets the phone number.
        public string PhoneNumber { get; set; }
        // Gets or sets the password.
        public string Password { get; set; }
        // Gets or sets the request date.
        public DateTime RequestDate { get; set; }
        // Gets or sets the request status.
        public string RequestStatus { get; set; }
        // Initializes a new instance of the AccountRequest class.
        public AccountRequest(string requestId, string firstName, string lastName, string email, string phoneNumber, string password, DateTime requestDate, string requestStatus)
        {
            // Set the request ID.
            RequestId = requestId;
            // Set the first name.
            FirstName = firstName;
            // Set the last name.
            LastName = lastName;
            // Set the email.
            Email = email;
            // Set the phone number.
            PhoneNumber = phoneNumber;
            // Set the password.
            Password = password;
            // Set the request date.
            RequestDate = requestDate;
            // Set the request status.
            RequestStatus = requestStatus;
        }
    }
}
