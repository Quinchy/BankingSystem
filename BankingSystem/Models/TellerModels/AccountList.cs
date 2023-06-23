using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Models.TellerModels
{
    // Defines the Account class.
    internal class AccountList
    {
        // Gets or sets the account ID.
        public string AccountId { get; set; }
        // Gets or sets the customer ID.
        public string CustomerId { get; set; }
        // Gets or sets the first name of the customer.
        public string FirstName { get; set; }
        // Gets or sets the last name of the customer.
        public string LastName { get; set; }
        // Gets or sets the email of the customer.
        public string Email { get; set; }
        // Gets or sets the phone number of the customer.
        public string PhoneNumber { get; set; }
        // Gets or sets the password of the customer.
        public string Password { get; set; }
        // Gets or sets the account balance.
        public double Balance { get; set; }
        // Gets or sets the account status.
        public string AccountStatus { get; set; }

        // Initializes a new instance of the AccountList class.
        public AccountList(string accountId, string firstName, string lastName, string email, string phoneNumber, string password, double balance, string accountStatus)
        {
            // Set the account ID.
            AccountId = accountId;
            // Set the first name of the customer.
            FirstName = firstName;
            // Set the last name of the customer.
            LastName = lastName;
            // Set the email of the customer.
            Email = email;
            // Set the phone number of the customer.
            PhoneNumber = phoneNumber;
            // Set the password of the customer.
            Password = password;
            // Set the account balance.
            Balance = balance;
            // Set the account status.
            AccountStatus = accountStatus;
        }
    }
}
