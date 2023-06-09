﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Models.TellerModels
{
    // Defines the TransactionRequest class.
    internal class TransactionRequest
    {
        // Gets or sets the process ID.
        public string ProcessId { get; set; }
        // Gets or sets the sender full name.
        public string SenderFullName { get; set; }
        // Gets or sets the sender account ID.
        public string SenderAccountId { get; set; }
        // Gets or sets the current balance.
        public double CurrentBalance { get; set; }
        // Gets or sets the transaction type.
        public string TransactionType { get; set; }
        // Gets or sets the receiver full name.
        public string ReceiverFullName { get; set; }
        // Gets or sets the receiver account ID.
        public string ReceiverAccountId { get; set; }
        // Gets or sets the amount.
        public double Amount { get; set; }
        // Gets or sets the transaction status.
        public string TransactionStatus { get; set; }

        // Initializes a new instance of the TransactionRequestDetail class.
        public TransactionRequest(
            string processId,
            string senderFullName,
            string senderAccountId,
            double currentBalance,
            string transactionType,
            string receiverFullName,
            string receiverAccountId,
            double amount,
            string transactionStatus)
        {
            ProcessId = processId;
            SenderFullName = senderFullName;
            SenderAccountId = senderAccountId;
            CurrentBalance = currentBalance;
            TransactionType = transactionType;
            ReceiverFullName = receiverFullName;
            ReceiverAccountId = receiverAccountId;
            Amount = amount;
            TransactionStatus = transactionStatus;
        }
    }
}
