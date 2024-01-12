namespace PrimeTable.Frontend.Models
{
    public class MultiplicationTableViewModel
    {
        public int Size { get; set; }
        public List<PrimeNumberModel> PrimeNumbers { get; set; }
        public GridCellModel[,] TableGrid { get; set; }
    }
}
