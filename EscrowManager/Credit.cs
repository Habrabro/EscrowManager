using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrowManager
{
    class Credit
    {
        float sum, rate, debtBalance, penalties;
        int term;
        public bool IsRepaid { get; private set; }
        bool isAnnuity;
        DateTime beginPayment;
        ContractSubject borrower;
        Bank creditor;

        public void makeRepayment()
        {
            float monthRate = rate / 12;
            float annuityRatio, paymentSum;
            if (isAnnuity)
            {
                annuityRatio = monthRate * (float)Math.Pow((1 + monthRate),
                    term) / ((float)Math.Pow((1 + monthRate), term) - 1);
                paymentSum = sum * annuityRatio;
                borrower.account.Withdraw(new Money(paymentSum, borrower.account.CurrentBalance.Currency));
                debtBalance -= paymentSum; // Переменные, хранящие деньги, должны иметь класс Money
            }
        }

        void chargePenalty(string message, bool status)
        {
            if (!status)
            {
                penalties *= 1.2f;
                debtBalance += penalties;
            }
        }

        public Credit(float _sum, float _rate, int _term, DateTime bPayment, bool _isAnnuity,
            ContractSubject _borrower, Bank _creditor, float _penalties)
        {
            sum = _sum;
            rate = _rate;
            term = _term;
            debtBalance = sum;
            beginPayment = bPayment;
            IsRepaid = false;
            isAnnuity = _isAnnuity;
            borrower = _borrower;
            creditor = _creditor;
            penalties = _penalties;
            borrower.account.Withdrawn += chargePenalty;
        }
    }
}
