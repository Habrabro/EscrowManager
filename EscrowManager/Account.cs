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
        public delegate void AccountStateHandler(string message, bool status);
        public event AccountStateHandler Added;
        public event AccountStateHandler Withdrawn;

        public Money CurrentBalance { get; private set; }
                
        public void Put(Money money)
        {
            CurrentBalance += money;
            Added?.Invoke($"На счёт поступило {money.Sum} {money.Currency}", true);
        }

        public void Withdraw(Money money)
        {
            if (CurrentBalance - money >= new Money(0, money.Currency))
            {
                CurrentBalance -= money;
                Withdrawn?.Invoke($"Со счёта списано {money.Sum} {money.Currency}", true);
            }
            else
            {
                Withdrawn?.Invoke("На счёте не достаточно средств для списания.", false);
            }
        }

        public Account(Money money)
        {
            CurrentBalance = money;
        }
    }
}
