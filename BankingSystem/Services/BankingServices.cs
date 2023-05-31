using BankingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Services
{
    internal class BankingServices
    {
        public static Account loadAccountInformation(string email)
        {
            Account currentAccount;
            string accountID = "";
            string transactionId = "";
            double balance = 0.00;
            string transactionType = "";
            // This method will load the user information from the database
            // Open Connection
            // Write an SQL statement that will retrieve the data from the database and store it in the Customer Object.
            currentAccount = new Account(
                accountID,
                transactionId,
                balance,
                transactionType
            );
            // Close Connection
            return currentAccount;
        }
    }
}
