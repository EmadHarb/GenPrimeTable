namespace PrimeTable.Frontend.Models
{
    public class GridCellModel
    {
        public PrimeNumberModel RowValue { get; set; }
        public PrimeNumberModel ColumnValue { get; set; }
        public int Product => RowValue.Value * ColumnValue.Value;
    }
}
