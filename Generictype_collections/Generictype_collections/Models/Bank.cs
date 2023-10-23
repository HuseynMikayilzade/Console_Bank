using Generictype_collections.Interfaces;
using Generictype_collections.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generictype_collections.Models
{
    internal class Bank 
    {
        private List<Account> accounts= new List<Account>();

        public Bank()
        {
            accounts = new List<Account> ();
        }

        public Account CreateAccount()
        {
            int Count = accounts.Count + 1;
            Account account = new Account(Count);
            accounts.Add(account);
            return account;
        }
        public void DepositMoney(int accountid , decimal amount)
        {
            Account account = Find(accountid);
            account.Deposit(amount);
            Console.WriteLine($"Balans: {account.Balance}");

        }
        public void WithDrawMoney(int accountid , decimal amount)
        {

            Account account = Find(accountid); 
            account.WithDraw(amount);
            Console.WriteLine($"Balans: {account.Balance}");
            //ASAGIDAKI USULLA ALINDIRA BILMEDIM//

            //foreach (var account in accounts)
            //{
            //    if (accountid == account.AccountId)
            //    {
            //        account.WithDraw(amount); 
            //        break;
            //    }
            //    else
            //    {
            //        throw new AccountNotFoundException("Hesab tapilmadi");
            //    }
            //}
        }
        public void TransferMoney(int fromaccountid , int toaccountid ,decimal amount)
        {
            Account account= Find(fromaccountid);
            Account account1 = Find(toaccountid);
            account.WithDraw(amount);
            account1.Deposit(amount);
            Console.WriteLine($"Gonderen hesabin balansi: {account.Balance} \nQebul eden hesabin balansi: {account1.Balance}");
        }
        public Account Find(int accountId)
        {
            foreach (var account in accounts)
            {
                if (accountId == account.AccountId)
                {
                    return account; 
                }
            }
            throw new AccountNotFoundException("Hesab tapilmadi"); 
        }
        public List<Account> GetAllAccounts()
        {
            return accounts;
        }
    
    }
}
