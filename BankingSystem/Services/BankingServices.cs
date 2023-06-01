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
            double balance = 0.00;
            // This method will load the user information from the database
            // Open Connection
            // Write an SQL statement that will retrieve the data from the database and store it in the Customer Object.
            currentAccount = new Account(
                accountID,
                balance
            );
            // Close Connection
            return currentAccount;
        }
    }
}
