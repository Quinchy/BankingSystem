using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Models.TellerModels
{
    internal class Transaction
    {
        // Gets or sets the process ID.
        public string ProcessId { get; set; }
        // Gets or sets the sender full name.
        public string SenderFullName { get; set; }
        // Gets or sets the sender account ID.
        public string SenderAccountId { get; set; }
        // Gets or sets the transaction type.
        public string TransactionType { get; set; }
        // Gets or sets the transaction type.
        public DateTime TransactionDate { get; set; }
        // Get or sets the transaction id.
        public string TransactionId { get; set; }
        // Gets or sets the receiver full name.
        public string ReceiverFullName { get; set; }
        // Gets or sets the receiver account ID.
        public string ReceiverAccountId { get; set; }
        // Gets or sets the amount.
        public double Amount { get; set; }
        // Gets or sets the transaction status.
        public string ProcessStatus { get; set; }

        // Initializes a new instance of the TransactionRequestDetail class.
        public Transaction(
            string processId,
            string senderFullName,
            string senderAccountId,
            string transactionType,
            DateTime transactionDate,
            string transactionId,
            string receiverFullName,
            string receiverAccountId,
            double amount,
            string processStatus)
        {
            ProcessId = processId;
            SenderFullName = senderFullName;
            SenderAccountId = senderAccountId;
            TransactionType = transactionType;
            TransactionDate = transactionDate;
            TransactionId = transactionId;
            ReceiverFullName = receiverFullName;
            ReceiverAccountId = receiverAccountId;
            Amount = amount;
            ProcessStatus = processStatus;
        }
    }
}
