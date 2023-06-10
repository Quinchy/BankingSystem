using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Models.TellerModels
{
    internal class Account
    {
        public string AccountId { get; set; }
        public string CustomerId { get; set; }
        public double Balance { get; set; }
        public string AccountStatus { get; set; }
        public Account(string accountId, string customerId, double balance, string accountStatus)
        {
            AccountId = accountId;
            CustomerId = customerId;
            Balance = balance;
            AccountStatus = accountStatus;
        }
    }
}
