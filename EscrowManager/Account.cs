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
        public delegate void AccountStateHandler(string message);
        public event AccountStateHandler Added;
        public event AccountStateHandler Withdrawn;

        Converter converter;

        public float CurrentBalance { get; private set; }
        public void Put(float sum, Currencies currency)
        {
            CurrentBalance += sum;
            Added?.Invoke($"На счёт поступило {sum} {currency}");
        }
        public void Put(float sum, Currencies initialCurrency, Currencies targetCurrency)
        {
            sum = converter.convert(sum, initialCurrency, targetCurrency);
            CurrentBalance += sum;
            Added?.Invoke($"На счёт поступило {sum} {targetCurrency} (переведено из {initialCurrency} в {targetCurrency})");
        }

        public void Withdraw(float sum, Currencies currency)
        {
            CurrentBalance -= sum;
            Withdrawn?.Invoke($"Со счёта списано {sum} {currency}");
        }
        public void Withdraw(float sum, Currencies initialCurrency, Currencies targetCurrency)
        {
            sum = converter.convert(sum, initialCurrency, targetCurrency);
            CurrentBalance -= sum;
            Withdrawn?.Invoke($"Со счёта списано {sum} {targetCurrency} (переведено из {initialCurrency} в {targetCurrency})");
        }

        public Account(float initialBalance)
        {
            CurrentBalance = initialBalance;
            converter = new Converter();
        }
    }
}
