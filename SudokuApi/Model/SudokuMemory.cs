namespace SudokuApi.Model
{
    public class SudokuMemory
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public required int[] Y { get; set; }
        public required int[] X { get; set; }
        public required int[] Z { get; set; }



    }
}
