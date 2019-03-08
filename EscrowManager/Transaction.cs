using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrowManager
{
    class Transaction
    {
        public void makeTransaction(ContractSubject sender, ContractSubject receiver, float sum, Currencies cur)
        {
            sender.account.Withdraw(sum, cur);
            receiver.account.Put(sum, cur);
        }
        public void makeTransaction(ContractSubject sender, ContractSubject receiver, float sum, Currencies initCur, Currencies tarCur)
        {
            sender.account.Withdraw(sum, initCur);
            receiver.account.Put(sum, initCur, tarCur);
        }
    }
}
