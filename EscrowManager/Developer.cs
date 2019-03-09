using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrowManager
{
    class Developer : Beneficiary
    {
        public Developer(string name, Money money) : base(name, money)
        {

        }
    }
}
