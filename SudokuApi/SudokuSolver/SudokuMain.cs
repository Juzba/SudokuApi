namespace SudokuApi.SudokuSolver
{
    public class SudokuMain
    {

        public static int[][][] Main(int[][][] data)
        {
            // převod pole int[,,] z příchozího int[][][]
           int[,,] pole = ChangeArrayFromInput(data);




            pole[8, 0, 0] = 20;




            return ChangeArrayToOutput(pole);
        }


        private static int[,,] ChangeArrayFromInput(int[][][] data)
        {
            int[,,] inputArray = new int[9, 9, 10];

            for (int y = 0; y < data.Length; y++)
                for (int x = 0; x < data[0].Length; x++)
                    for (int z = 0; z < data[0][0].Length; z++)
                        inputArray[y, x, z] = data[y][x][z];

            return inputArray;
        }


        private static int[][][] ChangeArrayToOutput(int[,,] data)
        {
            int[][][] outputArray = new int[9][][];

            for (int y = 0; y < 9; y++)
            {
                outputArray[y] = new int[9][];

                for (int x = 0; x < 9; x++)
                {
                    outputArray[y][x] = new int[10];
                    for (int z = 0; z < 10; z++)
                    {
                        outputArray[y][x][z] = data[y, x, z];
                    }
                }
            }
            return outputArray;
        }


    }
}
