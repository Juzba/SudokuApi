namespace SudokuApi.SudokuSolver
{
    public class SudokuMain
    {

        public static int[][][] SolveMain(int[][][] data)
        {
            // převod pole int[,,] z příchozího int[][][]
            int[,,] array = ChangeArrayFromInput(data);

            if (true) {
                ScanMetods.Main(array);
            }
            else
            {

            //Scan array[,,] with diferent metods to find posible numbers.
            ScanMetods.Main(array);
            //if number is not minus set number to plus(small numbers from array Z)
            // staci pouze poprve !!
            ScanMetods.PossibleNumbersScan(array);



            //// If on rows is only one small number -> set number as big number
            FindNumber.RowsOrCollumnsSearch(array, false);
            //// If on Columns is only one small number -> set number as big number
            FindNumber.RowsOrCollumnsSearch(array, true);


            //Scan array[,,] with diferent metods to find posible numbers.
            ScanMetods.Main(array);


            // if only one small number in segment set number as big.
            FindNumber.OneSmallNumberToBigNumber(array);


            //Scan array[,,] with diferent metods to find posible numbers.
            ScanMetods.Main(array);


            // if only one small number in section set it to big number.
            //FindNumber.OnlyOneSmallNumberInSection(array);



            }



            return ChangeArrayToOutput(array);
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
