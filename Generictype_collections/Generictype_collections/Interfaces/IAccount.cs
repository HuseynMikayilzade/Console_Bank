using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generictype_collections.Interfaces
{
    internal interface IAccount
    {
        int AccountId { get;  }
        decimal Balance { get; } 

        void Deposit(decimal amount);
        void WithDraw(decimal amount);
    }
}
