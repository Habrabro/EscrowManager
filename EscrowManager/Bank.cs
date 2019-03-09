using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrowManager
{
    class Bank : ContractSubject
    {
        public delegate void ObligationsStateHandler(bool status);
        public event ObligationsStateHandler ObligationsFulfilledEvent;

        bool obligationsFulfilled;
        public bool ObligationsFulfilled
        {
            get
            {
                return obligationsFulfilled;
            }
            set
            {
                ObligationsFulfilledEvent?.Invoke(value);
            }
        }

        Converter converter = new Converter();

        public void makeTransaction(ContractSubject sender, ContractSubject receiver, Money money)
        {
            sender.account.Withdraw(money);
            receiver.account.Put(money);
        }

        public Bank(string name, Money money) : base(name, money)
        {
            obligationsFulfilled = false;
        }
    }
}
