namespace SudokuApi.SudokuSolver
{
    public class ScanError
    {
        //false without errors
        public static bool MainFunc(int[,,] array)
        {

            return
                AreSameNumbersInLine(array, false)
               || AreSameNumbersInLine(array, true)
               || AreSameNumbersInOneSection(array);
        }




        // if two same numbers is on same row or collumn return true
        private static bool AreSameNumbersInLine(int[,,] array, bool forCollumns = false)
        {
            for (int number = 1; number < 10; number++)
                for (int Y = 0; Y < 9; Y++)
                {
                    int count = 0;

                    for (int X = 0; X < 9; X++)
                    {
                        if (forCollumns && array[X, Y, 0] == number) count++;
                        else if (!forCollumns && array[Y, X, 0] == number) count++;
                        if (count > 1) return true;
                    }
                }
            return false;
        }


        // if two same number are in same section return error bool true
        private static bool AreSameNumbersInOneSection(int[,,] array)
        {
            // for number 1 - 9 in sudoku
            for (int number = 1; number < 10; number++)

                for (int sectionY = 0; sectionY < 3; sectionY++)
                    for (int sectionX = 0; sectionX < 3; sectionX++)
                    {

                        int count = 0;

                        for (int Y = 0 + (sectionY * 3); Y < 3 + (sectionY * 3); Y++)
                            for (int X = 0 + (sectionX * 3); X < 3 + (sectionX * 3); X++)
                                if (array[Y, X, 0] == number)
                                {
                                    count++;
                                    if (count > 1) return true;
                                }
                    }
                
            return false;
        }

       












    }
}
