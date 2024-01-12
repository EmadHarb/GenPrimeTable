using PrimeTable.Application.Services;
using PrimeTable.Domain.Entities;
using PrimeTable.Domain.ValueObjects;

namespace PrimeTable.Application.Tests
{
    public class MultiplicationTableServiceTests
    {
        private PrimeNumberService _service;

        public MultiplicationTableServiceTests()
        {
            _service = new PrimeNumberService();
        }

        [Fact]
        public void Constructor_ThrowsException_WhenPrimeNumberServiceIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => new MultiplicationTableService(null));
        }

        [Fact]
        public void CreateMultiplicationTable_ThrowsException_WhenSizeIsLessThanOne()
        {
            var service = new MultiplicationTableService(_service);

            Assert.Throws<ArgumentException>(() => service.CreateMultiplicationTable(0));
        }
        

        [Fact]
        public void CreateMultiplicationTable_ReturnsMultiplicationTable_WhenSizeIsValid()
        {
            int size = 3;
            var service = new MultiplicationTableService(_service);

            var result = service.CreateMultiplicationTable(size);

            Assert.NotNull(result);
            Assert.Equal(size, result.PrimeNumbers.Count);
            Assert.Equal(size, result.Size);
        }

    }

}
