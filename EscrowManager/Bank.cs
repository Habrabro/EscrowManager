using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrowManager
{
    class Bank : ContractSubject
    {
        public delegate void ObligationsStateHandler(string message);
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
                ObligationsFulfilledEvent?.Invoke($"Статус выполнения обязательств изменён на {value}.");
            }
        }

        public Bank(string name, float initialBalance) : base(name, initialBalance)
        {
            obligationsFulfilled = false;
        }
    }
}
