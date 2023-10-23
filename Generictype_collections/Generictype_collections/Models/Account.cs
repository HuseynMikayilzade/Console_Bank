using Generictype_collections.Exceptions;
using Generictype_collections.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generictype_collections.Models
{
    internal class Account : IAccount
    {
        private List<Transaction> transactions = new List<Transaction>() ; 

        public int AccountId {  get; set; }
        public decimal Balance { get; set; } 

        public Account(int accountid)
        {
            AccountId = accountid;
            Balance = 0;
            transactions = new List<Transaction>();
        }

        public void Deposit(decimal amount)
        {
            if (amount<=0)
            {
                throw new InvalidAmountException("daxil etdiyiniz mebleg dogru deyil");                  
            }
            else
            {             
                Balance += amount;
                transactions.Add(new Transaction(transactions.Count + 1, amount, DateTime.Now, "Deposit"));
            }
        }

        public void WithDraw(decimal amount)
        {
            if (Balance<amount)
            {
                throw new InsufficientFundsException("Balansinizda kifayet qeder mebleg yoxdur");
            }
            else if (amount <= 0)
            {
                throw new InvalidAmountException("Daxil etdiyiniz mebleg dogru deyil");
            }
            else
            { 
                Balance -= amount;
                transactions.Add(new Transaction(transactions.Count + 1, amount, DateTime.Now, "Witdraw"));

            }
        }

        public override string ToString()
        {
            return $"Balans: {Balance} \nHesab nomresi: {AccountId}";
        }
    }
}
