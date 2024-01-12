using PrimeTable.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeTable.Domain.Interfaces
{
    public interface IPrimeNumberService
    {
        List<PrimeNumber> GenerateNPrimeNumbers(int n);

    }
}
