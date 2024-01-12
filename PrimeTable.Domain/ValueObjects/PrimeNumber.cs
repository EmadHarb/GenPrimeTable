using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeTable.Domain.ValueObjects
{
    public class PrimeNumber
    {
        public int Value { get; }

        public PrimeNumber(int value)
        {
            if (!IsPrimeNumber(value))
            {
                throw new ArgumentException("Your value must be a prime number.", nameof(value));
            }

            Value = value;
        }

        private bool IsPrimeNumber(int number)
        {
            if (number < 2) return false;

            var numberSqrt = Math.Sqrt(number);

            for (int i = 2; i <= numberSqrt; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
