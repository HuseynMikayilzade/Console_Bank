using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Generictype_collections.Exceptions
{
    internal class InsufficientFundsException : Exception
    {
       public InsufficientFundsException(string message):base(message) { }
    }
}
