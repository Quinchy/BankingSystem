using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Models.TellerModels
{
    // Defines the Account class.
    internal class Account
    {
        // Gets or sets the account ID.
        public string AccountId { get; set; }
        // Gets or sets the customer ID.
        public string CustomerId { get; set; }
        // Gets or sets the account balance.
        public double Balance { get; set; }
        // Gets or sets the account status.
        public string AccountStatus { get; set; }
        // Initializes a new instance of the Account class.
        public Account(string accountId, string customerId, double balance, string accountStatus)
        {
            // Set the account ID.
            AccountId = accountId;
            // Set the customer ID.
            CustomerId = customerId;
            // Set the account balance.
            Balance = balance;
            // Set the account status.
            AccountStatus = accountStatus;
        }
    }
}
