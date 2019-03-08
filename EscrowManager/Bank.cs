using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrowManager
{
    class Bank : ContractSubject
    {
        public Bank(string name, float initialBalance) : base(name, initialBalance)
        {
            
        }
    }
}
