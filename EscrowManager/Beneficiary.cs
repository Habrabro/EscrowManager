﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrowManager
{
    abstract class Beneficiary : ContractSubject
    {       

        public Beneficiary(string name, Money money) : base(name, money)
        {

        }
    }
}
