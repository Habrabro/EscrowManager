using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrowManager
{
    enum Currencies { rub, dol, eur };

    class Converter
    {
        static int enumLength = Enum.GetNames(typeof(Currencies)).Length;
        static float[,] rates;
        Random random = new Random();

        static public Money convert(Money money, Currencies targetCurrency)
        {
            return new Money(money.Sum * rates[(int)money.Currency, (int)targetCurrency], targetCurrency);
        }

        public Converter()
        {
            rates = new float[enumLength, enumLength];
            for (int i = 0; i < enumLength; i++)
            {
                for (int j = 0; j < enumLength; j++)
                {
                    rates[i, j] = random.Next(100);
                }
            }
        }
    }
}
