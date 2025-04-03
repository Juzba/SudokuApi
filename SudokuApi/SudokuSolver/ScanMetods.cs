namespace SudokuApi.SudokuSolver
{
    public class ScanMetods
    {

        // Number 1
        // scan numbers, if find number -> all numbers in line canot be this number 
        public static int[,,] RowsOrCollumnsScan(int[,,] array, bool forCollumns = false)
        {
            // for number 1 - 9
            for (int number = 1; number < 10; number++)
            {
                // for dimensions Y X
                for (int Y = 0; Y < array.GetLength(0); Y++)
                {
                    bool IsNumberFind = false;
                    for (int X = 0; X < array.GetLength(1); X++)
                    {
                        // if find big number -> set small numbers to minus
                        if (array[Y, X, 0] > 0) array[Y, X, number] = -1 * number;

                        if (forCollumns)
                        {
                            // for collumns
                            if (IsNumberFind) array[X, Y, number] = -1 * number;
                            if (!IsNumberFind && number == array[X, Y, 0]) { IsNumberFind = true; X = -1; }
                        }
                        else
                        {
                            // for rows
                            if (IsNumberFind) array[Y, X, number] = -1 * number;
                            if (!IsNumberFind && number == array[Y, X, 0]) { IsNumberFind = true; X = -1; }
                        }
                    }

                }

            }
            return array;
        }



        // Number 2
        // if number array Z (small-number) is not minus then set number to plus +number; 

        public static int[,,] PossibleNumbersScan(int[,,] array)
        {

            for (int number = 1; number < 10; number++)
            {

                for (int Y = 0; Y < array.GetLength(0); Y++)
                    for (int X = 0; X < array.GetLength(1); X++)
                        if (array[Y, X, 0] == 0 && array[Y, X, number] != -1 * number) array[Y, X, number] = number;
                       
                    
            }
            return array;
        }





    }
}

