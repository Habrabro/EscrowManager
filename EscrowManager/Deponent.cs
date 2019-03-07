using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrowManager
{
    abstract class Deponent
    {
        string name;

        Account account;
        public Deponent(float initialBalance)
        {
            account = new Account(initialBalance);
        }
    }
}
