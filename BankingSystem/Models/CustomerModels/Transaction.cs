using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Models.CustomerModels
{
    // Defines the Transaction class.
    internal class Transaction
    {
        // Gets or sets the transaction ID.
        public string TransactionId { get; set; }
        // Gets or sets the transaction amount.
        public double Amount { get; set; }
        // Gets or sets the transaction date.
        public DateTime Date { get; set; }
        // Gets or sets the transaction type.
        public string TransactionType { get; set; }
        // Initializes a new instance of the Transaction class.
        public Transaction(string transactionId, double amount, DateTime date, string type)
        {
            // Set the transaction ID.
            TransactionId = transactionId;
            // Set the transaction amount.
            Amount = amount;
            // Set the transaction date.
            Date = date;
            // Set the transaction type.
            TransactionType = type;
        }
    }
}