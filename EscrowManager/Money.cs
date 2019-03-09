using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrowManager
{
    class Money
    {
        public float Sum { get; private set; }
        public Currencies Currency { get; private set; }

        public static Money operator + (Money op1, Money op2)
        {
            if (op1.Currency == op2.Currency)
            {
                return new Money(op1.Sum + op2.Sum, op1.Currency);
            }
            else
            {
                Money convertedMoney = Converter.convert(op2, op1.Currency);
                return new Money(op1.Sum + convertedMoney.Sum, op1.Currency);
            }
        }
        public static Money operator - (Money op1, Money op2)
        {
            if (op1.Currency == op2.Currency)
            {
                return new Money(op1.Sum - op2.Sum, op1.Currency);
            }
            else
            {
                Money convertedMoney = Converter.convert(op2, op1.Currency);
                return new Money(op1.Sum - convertedMoney.Sum, op1.Currency);
            }
        }
        public static bool operator == (Money op1, Money op2)
        {
            if (op1.Currency == op2.Currency)
            {
                return op1.Sum == op2.Sum;
            }
            else
            {
                Money convertedMoney = Converter.convert(op2, op1.Currency);
                return op1.Sum == convertedMoney.Sum;
            }
        }
        public static bool operator !=(Money op1, Money op2)
        {
            if (op1.Currency == op2.Currency)
            {
                return op1.Sum != op2.Sum;
            }
            else
            {
                Money convertedMoney = Converter.convert(op2, op1.Currency);
                return op1.Sum != convertedMoney.Sum;
            }
        }
        public static bool operator >(Money op1, Money op2)
        {
            if (op1.Currency == op2.Currency)
            {
                return op1.Sum > op2.Sum;
            }
            else
            {
                Money convertedMoney = Converter.convert(op2, op1.Currency);
                return op1.Sum > convertedMoney.Sum;
            }
        }
        public static bool operator <(Money op1, Money op2)
        {
            if (op1.Currency == op2.Currency)
            {
                return op1.Sum < op2.Sum;
            }
            else
            {
                Money convertedMoney = Converter.convert(op2, op1.Currency);
                return op1.Sum < convertedMoney.Sum;
            }
        }
        public static bool operator >=(Money op1, Money op2)
        {
            if (op1.Currency == op2.Currency)
            {
                return op1.Sum >= op2.Sum;
            }
            else
            {
                Money convertedMoney = Converter.convert(op2, op1.Currency);
                return op1.Sum >= convertedMoney.Sum;
            }
        }
        public static bool operator <=(Money op1, Money op2)
        {
            if (op1.Currency == op2.Currency)
            {
                return op1.Sum <= op2.Sum;
            }
            else
            {
                Money convertedMoney = Converter.convert(op2, op1.Currency);
                return op1.Sum <= convertedMoney.Sum;
            }
        }

        public Money(float _sum, Currencies _currency)
        {
            Sum = _sum;
            Currency = _currency;
        }
    }
}
