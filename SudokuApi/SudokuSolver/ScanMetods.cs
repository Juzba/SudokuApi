namespace SudokuApi.SudokuSolver
{
    public class ScanMetods
    {

        public static int[,,] Main(int[,,] array)
        {
            //scan for rows
            //RowsOrCollumnsScan(array, false);
            // scan for collumns
            //RowsOrCollumnsScan(array, true);
            // Clear all small numbers in section if same big number is in section
            ClearSmallNumbersInSection(array);
            return array;
        }



        // Number 1
        // scan numbers, if find number -> all numbers in line canot be this number 
        private static int[,,] RowsOrCollumnsScan(int[,,] array, bool forCollumns = false)
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



        // Number 3
        // Clear all small numbers in section if same big number is in section

        private static int[,,] ClearSmallNumbersInSection(int[,,] array)
        {

            // for number 1 - 9 in sudoku
            for (int number = 1; number < 10; number++)
            {

                // for section Y X
                for (int sectionY = 0; sectionY < 3; sectionY++)
                {
                    for (int sectionX = 0; sectionX < 3; sectionX++)
                    {

                        bool isNumberFind = false;

                        for (int Y = 0 + (sectionY * 3); Y < 3 + (sectionY * 3); Y++)
                        {
                            for (int X = 0 + (sectionX * 3); X < 3 + (sectionX * 3); X++)
                            {
                                if (!isNumberFind && array[X, Y, 0] == number)
                                {
                                    isNumberFind = true;
                                    Y = -1 + (sectionY * 3);
                                    break;
                                }
                                else if (isNumberFind) 
                                {
                                    array[Y, X, number] = -1 * number;
                                }
                            }
                        }
                    }
                }
            }
            return array;
        }






    }
}

