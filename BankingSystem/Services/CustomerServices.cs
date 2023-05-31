using BankingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Services
{
    internal class CustomerServices
    {
        public static Customer loadCustomerInformation(string email)
        {
            Customer currentCustomer;
            string firstName = "";
            string lastName = "";
            string emailAddress = "";
            string phoneNumber = "";
            string password = "";
            // This method will load the user information from the database
            // Open Connection
            // Write an SQL statement that will retrieve the data from the database and store it in the Customer Object.
            currentCustomer = new Customer(
                firstName,
                lastName,
                emailAddress,
                phoneNumber,
                password
            );
            // Close Connection
            return currentCustomer;
        }
    }
}
