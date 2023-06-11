using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Models.TellerModels
{
    // Defines the TransactionRequest class.
    internal class TransactionRequest
    {
        // Gets or sets the process ID.
        public string ProcessId { get; set; }
        // Gets or sets the account ID.
        public string AccountId { get; set; }
        // Gets or sets the balance.
        public double Balance { get; set; }
        // Gets or sets the transaction type.
        public string TransactionType { get; set; }
        // Gets or sets the amount.
        public double Amount { get; set; }
        // Gets or sets the process status.
        public string ProcessStatus { get; set; }
        // Initializes a new instance of the TransactionRequest class.
        public TransactionRequest(string processId, string accountId, double balance, string transactionType, double amount, string processStatus)
        {
            // Set the process ID.
            ProcessId = processId;
            // Set the account ID.
            AccountId = accountId;
            // Set the balance.
            Balance = balance;
            // Set the transaction type.
            TransactionType = transactionType;
            // Set the amount.
            Amount = amount;
            // Set the process status.
            ProcessStatus = processStatus;
        }
    }
}
