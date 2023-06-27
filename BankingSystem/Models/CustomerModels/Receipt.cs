using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Models.CustomerModels
{
    internal class Receipt
    {
        // Gets or sets the sender full name.
        public string SenderFullName { get; set; }
        // Gets or sets the sender account id.
        public string SenderAccountID { get; set; }
        // Gets or sets the receiver full name.
        public string ReceiverFullName { get; set; }
        // Gets or sets the receiver account id.
        public string ReceiverAccountID { get; set; }
        // Gets or sets the transaction type.
        public string TransactionType { get; set; }
        // Gets or sets the amount.
        public double Amount { get; set; }
        // Gets or sets the reference number.
        public string ReferenceNumber { get; set; }
        // Gets or sets the date of transaction
        public DateTime TransactionDate { get; set; }

        // Initializes a new instance of the Receipt class.
        public Receipt(string senderFullName, string senderAccountId, string receiverFullName, string receiverAccountId, string transactionType, double amount, string referenceNumber, DateTime transactionDate)
        {
            // Set the sender full name.
            SenderFullName = senderFullName;
            // Set the sender account ID.
            SenderAccountID = senderAccountId;
            // Set the receiver full name.
            ReceiverFullName = receiverFullName;
            // Set the receiver account ID.
            ReceiverAccountID = receiverAccountId;
            // Set the transaction type.
            TransactionType = transactionType;
            // Set the amount.
            Amount = amount;
            // Set the reference number.
            ReferenceNumber = referenceNumber;
            // Set the date of transaction.
            TransactionDate = transactionDate;
        }
    }
}
