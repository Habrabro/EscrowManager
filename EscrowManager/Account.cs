using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EscrowManager
{
    class Account
    {
        float balance;

        public void Add(float sum)
        {
            balance += sum;
        }
        public void Sub(float sum)
        {
            balance -= sum;
        }

        public Account(float initialBalance)
        {
            balance = initialBalance;
        }
    }
}
