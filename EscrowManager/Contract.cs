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
        public event ContractSignHandler Signed;
        public event ContractSignHandler Dissolved;

        Bank escrowAgent;
        Deponent deponent;
        Beneficiary beneficiary;
        Transaction transaction;
        Currencies currency;
        float contractSum;
        public bool IsActive { get; private set; }

        void ObligationsFulfilled(string message)
        {
            transaction.makeTransaction(escrowAgent, beneficiary, contractSum, currency);
            MessageBox.Show("Обязательства бенефициара исполнены.");
        }

        public Contract(Bank eAgent, Deponent dep, Beneficiary ben, float sum, Currencies cur)
        {
            escrowAgent = eAgent;
            deponent = dep;
            beneficiary = ben;
            contractSum = sum;
            currency = cur;

            transaction = new Transaction();
            transaction.makeTransaction(dep, eAgent, contractSum, currency);

            IsActive = true;

            Signed?.Invoke($"Контракт заключён. На счёт эскроу внесено {contractSum} {currency}.");

            eAgent.ObligationsFulfilledEvent += ObligationsFulfilled;
        }
    }
}
