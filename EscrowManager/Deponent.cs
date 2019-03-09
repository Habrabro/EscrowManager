using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrowManager
{
    abstract class Deponent : ContractSubject
    {
        public Deponent(string name, Money money) : base(name, money)
        {

        }
    }
}
