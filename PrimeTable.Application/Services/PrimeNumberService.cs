using PrimeTable.Domain.Interfaces;
using PrimeTable.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeTable.Application.Services
{
    public class PrimeNumberService : IPrimeNumberService
    {
        //This method will generate and return all the n prime numbers starting from 2 
        //Starting from 2 and check if the number is prime and add it to the array until reaching the required n numbers
        public List<PrimeNumber> GenerateNPrimeNumbers(int n)
        {
            if (n < 1) throw new ArgumentException();

            List<PrimeNumber> primes = new List<PrimeNumber>();
            int num = 2; // since it is the first prime number

            while (primes.Count < n)
            {
                if (IsPrime(num))
                {
                    primes.Add(new PrimeNumber(num));
                }
                num++;
            }

            return primes;
        }

        private bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
