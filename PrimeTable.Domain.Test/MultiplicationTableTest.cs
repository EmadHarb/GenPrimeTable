using PrimeTable.Domain.Entities;
using PrimeTable.Domain.ValueObjects;

namespace PrimeTable.Domain.Test
{
    public class MultiplicationTableTest
    {
        [Fact]
        public void Constructor_ShouldThrowException_WhenPrimeNumbersIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => new MultiplicationTable(null));
        }

        [Fact]
        public void Constructor_ShouldSetSize_WhenPrimeNumbersIsNotNull()
        {
            var primeNumbers = new List<PrimeNumber> { new PrimeNumber(2), new PrimeNumber(3) };
            var table = new MultiplicationTable(primeNumbers);

            Assert.Equal(2, table.Size);
        }

        [Fact]
        public void Constructor_ShouldSetPrimeNumbers_WhenPrimeNumbersIsNotNull()
        {
            var primeNumbers = new List<PrimeNumber> { new PrimeNumber(2), new PrimeNumber(3) };
            var table = new MultiplicationTable(primeNumbers);

            Assert.Equal(primeNumbers, table.PrimeNumbers);
        }

        [Fact]
        public void TableGrid_ShouldBePopulated_WithCorrectGridCells()
        {
            var primeNumbers = new List<PrimeNumber> { new PrimeNumber(2), new PrimeNumber(3) };
            var table = new MultiplicationTable(primeNumbers);

            Assert.IsType<GridCell>(table.TableGrid[0, 0]);

            Assert.Equal(2, table.TableGrid[0, 0].RowValue.Value);
            Assert.Equal(2, table.TableGrid[0, 0].ColumnValue.Value);

            Assert.Equal(3, table.TableGrid[1, 0].RowValue.Value);
            Assert.Equal(2, table.TableGrid[1, 0].ColumnValue.Value);

        }


    }
}