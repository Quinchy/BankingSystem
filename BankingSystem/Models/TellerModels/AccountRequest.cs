using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Models.TellerModels
{
    internal class AccountRequest
    {
        public string RequestId { get; set; }
        public string CustomerId { get; set; }
        public string Email { get; set; }
        public DateTime RequestDate { get; set; }
        public string RequestStatus { get; set; }
        public AccountRequest(string requestId, string customerId, string email, DateTime requestDate, string requestStatus)
        {
            RequestId = requestId;
            CustomerId = customerId;
            Email = email;
            RequestDate = requestDate;
            RequestStatus = requestStatus;
        }
    }
}
