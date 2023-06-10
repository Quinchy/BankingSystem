using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Models.TellerModels
{
    internal class TransactionRequest
    {
        public string ProcessId { get; set; }
        public string AccountId { get; set; }
        public double Balance { get; set; }
        public string TransactionType { get; set; }
        public double Amount { get; set; }
        public string ProcessStatus { get; set; }
        public TransactionRequest(string processId, string accountId, double balance, string transactionType, double amount, string processStatus)
        {
            ProcessId = processId;
            AccountId = accountId;
            Balance = balance;
            TransactionType = transactionType;
            Amount = amount;
            ProcessStatus = processStatus;
        }
    }
}
