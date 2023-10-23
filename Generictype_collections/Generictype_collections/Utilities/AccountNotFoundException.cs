using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generictype_collections.Utilities
{
    internal class AccountNotFoundException:Exception
    {
        public AccountNotFoundException(string message):base(message) { }
    }
}
