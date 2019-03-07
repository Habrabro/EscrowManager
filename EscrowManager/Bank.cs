using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrowManager
{
    class Bank
    {
        Account account;
        public Bank(float initialBalance)
        {
            account = new Account(initialBalance);
        }
    }
}
