using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Models.CustomerModels
{
    // Defines the Customer class.
    internal class Receipt
    {
        // Gets or sets the full name.
        public string FullName { get; set; }
        // Gets or sets the account id.
        public string AccountID { get; set; }
        // Gets or sets the transaction type.
        public string TransactionType { get; set; }
        // Gets or sets the amount.
        public double Amount { get; set; }
        // Gets or sets the reference number.
        public string ReferenceNumber { get; set; }
        // Gets or sets the date of transaction
        public DateTime TransactionDate { get; set; }
        // Initializes a new instance of the Receipt class.
        public Receipt(string fullName, string accountId, string transactionType, double amount, string referenceNumber, DateTime transactionDate)
        {
            // Set the full name.
            FullName = fullName;
            // Set the account ID.
            AccountID = accountId;
            // Set the transaction type.
            TransactionType = transactionType;
            // Set the amount.
            Amount = amount;
            // Set the reference number.
            ReferenceNumber = referenceNumber;
            // Set the date of transaction.
            TransactionDate = transactionDate;
        }
    }
}
