namespace SudokuApi.SudokuSolver
{
    public class FindNumber
    {

        //Number 1
        // If on row is only one small number -> set number as big number
        public static int[,,] RowSearch(int[,,] array)
        {
            //  for 1 - 9
            for (int number = 1; number < 10; number++)
            {


                for (int Y = 0; Y < 9; Y++)
                {

                    int count = 0;
                    int posY = 0;
                    int posX = 0;

                    for (int X = 0; X < 9; X++)
                    {
                        if (array[Y, X, number] == number) { ++count; posY = Y; posX = X; }
                    }
                    if (count == 1)
                        array[posY, posX, 0] = number;
                }
            }
            return array;
        }





    }
}
