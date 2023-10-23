using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generictype_collections.Models
{
    internal class Transaction
    {
        public Transaction(int transactionId, decimal amount, DateTime transactionDate, string transactionType)
        {
            TransactionId = transactionId;
            Amount = amount;
            TransactionDate = transactionDate;
            TransactionType = transactionType;
        }

        private int TransactionId { get; set; }
        private decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionType { get; set; }



    }
}
