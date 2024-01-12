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


        [Fact]
        public void MultiplicationTable_Constructor_ShouldPopulateTableGridCorrectly()
        {
            var primeNumbers = new List<PrimeNumber> { new PrimeNumber(2), new PrimeNumber(3), new PrimeNumber(5) };
            int expectedSize = primeNumbers.Count;

            var table = new MultiplicationTable(primeNumbers);

            Assert.NotNull(table.TableGrid);
            Assert.Equal(expectedSize, table.TableGrid.GetLength(0));
            Assert.Equal(expectedSize, table.TableGrid.GetLength(1));

            for (int i = 0; i < expectedSize; i++)
            {
                for (int j = 0; j < expectedSize; j++)
                {
                    var expectedProduct = primeNumbers[i].Value * primeNumbers[j].Value;
                    Assert.Equal(expectedProduct, table.TableGrid[i, j].Product);
                }
            }
        }
    }
}