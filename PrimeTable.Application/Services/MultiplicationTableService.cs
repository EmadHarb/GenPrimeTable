using PrimeTable.Domain.Entities;
using PrimeTable.Domain.Interfaces;

namespace PrimeTable.Application.Services
{
    public class MultiplicationTableService : IMultiplicationTableService
    {
        private readonly IPrimeNumberService _primeNumberService;

        public MultiplicationTableService(IPrimeNumberService primeNumberService)
        {
            _primeNumberService = primeNumberService ?? throw new ArgumentNullException(nameof(primeNumberService));
        }

        //Create the prime table based on the prime numbers generated
        public MultiplicationTable CreateMultiplicationTable(int size)
        {
            if (size < 1)
            {
                throw new ArgumentException("Size must be at least 1", nameof(size));
            }

            var primeNumbers = _primeNumberService.GenerateNPrimeNumbers(size); //.Select(num => new PrimeNumber(num)).ToList();
            return new MultiplicationTable(primeNumbers);
        }
    }
}
