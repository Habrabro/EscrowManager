using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrowManager
{
    abstract class ContractSubject
    {
        string name;
        public Account account;

        public ContractSubject(string name, Money money)
        {
            this.name = name;
            account = new Account(money);
        }
    }
}
