using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Models.CustomerModels
{
    // Defines the Customer class.
    internal class Customer
    {
        // Gets or sets the account ID.
        public string AccountId { get; set; }
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
        // Initializes a new instance of the Customer class.
        public Customer(string accountId, string firstName, string lastName, string email, string phoneNumber, string password)
        {
            // Set the account ID.
            AccountId = accountId;
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
        }
    }
}
