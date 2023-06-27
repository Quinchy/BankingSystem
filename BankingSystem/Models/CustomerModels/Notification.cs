using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Models.CustomerModels
{
    internal class Notification
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Message { get; set; }
        public bool IsSeen { get; set; }
        public DateTime CreatedAt { get; set; }

        // Initializes a new instance of the Notification class.
        public Notification(int id, int customerId, string message, bool isSeen, DateTime createdAt)
        {
            Id = id;
            CustomerId = customerId;
            Message = message;
            IsSeen = isSeen;
            CreatedAt = createdAt;
        }
    }

}
