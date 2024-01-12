using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeTable.Domain.ValueObjects
{
    public class GridCell
    {
        public PrimeNumber RowValue { get; }
        public PrimeNumber ColumnValue { get; }
        public int Product => RowValue.Value * ColumnValue.Value; //The product of the two prime numbers is provided here to make it easier for later use in the frontend and to encapsulate each GridCell

        public GridCell(PrimeNumber rowValue, PrimeNumber columnValue)
        {
            RowValue = rowValue ?? throw new ArgumentNullException(nameof(rowValue));
            ColumnValue = columnValue ?? throw new ArgumentNullException(nameof(columnValue));
        }
    }
}
