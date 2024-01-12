using PrimeTable.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeTable.Domain.Entities
{
    public class MultiplicationTable
    {
        public int Size { get; }
        public List<PrimeNumber> PrimeNumbers { get; private set; }
        public GridCell[,] TableGrid { get; private set; }

        public MultiplicationTable(List<PrimeNumber> primeNumbers)
        {
            PrimeNumbers = primeNumbers ?? throw new ArgumentNullException(nameof(primeNumbers));
            Size = primeNumbers.Count;
            GenerateTableGrid();
        }

        private void GenerateTableGrid()
        {
            TableGrid = new GridCell[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    TableGrid[i, j] = new GridCell(PrimeNumbers[i], PrimeNumbers[j]);
                }
            }
        }
    }
}
