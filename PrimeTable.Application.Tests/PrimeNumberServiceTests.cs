using PrimeTable.Application.Services;
using PrimeTable.Domain.ValueObjects;

namespace PrimeTable.Application.Tests
{
    public class PrimeNumberServiceTests
    {
        private PrimeNumberService _service;

        public PrimeNumberServiceTests()
        {
            _service = new PrimeNumberService();
        }

        [Fact]
        public void GenerateNPrimes_WithValidInput_ShouldReturnCorrectPrimes()
        {
            var result = _service.GenerateNPrimeNumbers(5);
            var expectedPrimes = new List<PrimeNumber> {
                new PrimeNumber(2),
                new PrimeNumber(3),
                new PrimeNumber(5),
                new PrimeNumber(7),
                new PrimeNumber(11)
            };

            for (int i = 0; i < expectedPrimes.Count; i++)
            {
                Assert.Equal(expectedPrimes[i].Value, result[i].Value);
            }
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void GenerateNPrimes_WithInvalidInput_ShouldThrowArgumentException(int n)
        {
            Assert.Throws<ArgumentException>(() => _service.GenerateNPrimeNumbers(n));
        }
    }
}