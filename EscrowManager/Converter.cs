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
        int enumLength = Enum.GetNames(typeof(Currencies)).Length;
        float[,] rates;
        Random random = new Random();
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
        public float convert(float sum, Currencies initialCurrency, Currencies targetCurrency)
        {
            return sum *= rates[(int)initialCurrency, (int)targetCurrency];
        }
    }
}
