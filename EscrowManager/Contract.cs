using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EscrowManager
{
    class Contract
    {
        public delegate void ContractSignHandler(string message);
        public event ContractSignHandler Dissolved;

        Bank escrowAgent;
        Deponent deponent;
        Beneficiary beneficiary;
        Currencies currency;
        Money contractSum;
        public bool IsActive { get; private set; }

        void ObligationsFulfilled(bool status)
        {
            if (status)
            {
                escrowAgent.makeTransaction(escrowAgent, beneficiary, contractSum);
                MessageBox.Show("Обязательства бенефициара исполнены.");
            }
        }

        public Contract(Bank eAgent, Deponent dep, Beneficiary ben, Money money)
        {
            escrowAgent = eAgent;
            deponent = dep;
            beneficiary = ben;
            contractSum = money;

            escrowAgent.makeTransaction(dep, eAgent, money);

            IsActive = true;

            eAgent.ObligationsFulfilledEvent += ObligationsFulfilled;
        }
    }
}
