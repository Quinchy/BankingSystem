using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Models
{
    internal class Transaction
    {
        public string TransactionId { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public string TransactionType { get; set; }

        public Transaction(string transactionId, double amount, string type)
        {
            TransactionId = transactionId;
            Amount = amount;
            Date = DateTime.Now;
            TransactionType = type;
        }
    }
}
