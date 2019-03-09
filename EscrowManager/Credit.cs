using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrowManager
{
    class Credit
    {
        float sum, rate, debtBalance;
        int term;
        public bool IsRepaid { get; private set; }
        bool isAnnuity;
        DateTime beginPayment;

        public void makeRepayment()
        {
            if (isAnnuity)
            {

            }
        }

        public Credit(float _sum, float _rate, int _term, DateTime bPayment, bool _isAnnuity)
        {
            sum = _sum;
            rate = _rate;
            term = _term;
            debtBalance = sum;
            beginPayment = bPayment;
            IsRepaid = false;
            isAnnuity = _isAnnuity;
        }
    }
}
