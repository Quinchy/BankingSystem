using BankingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Services
{
    internal class LoginServices
    {
        public static Boolean authenticateUser(String email, String password)
        {
            Boolean userExist = true;
            // This method will check if the user is in the database.
            // Open Connection
            // Write an SQL statement to check if the user is in the database then change userExist to true.
            // Close Connection
            return userExist;
        }
    }
}