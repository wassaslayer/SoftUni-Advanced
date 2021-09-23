using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            String[,] matrix = new string[rowsAndCols[0], rowsAndCols[1]];
            for (int rows = 0; rows < rowsAndCols[0]; rows++)
            {
                string[] elements = Console.ReadLine().Split(" ");
                for (int cols = 0; cols < rowsAndCols[1]; cols++)
                {
                    matrix[rows, cols] = elements[cols];
                }
            }
            int counter = 0;
            for (int rows = 0; rows < rowsAndCols[0] - 1; rows++)
            {
                for (int cols = 0; cols < rowsAndCols[1] - 1; cols++)
                {

                    if (matrix[rows, cols] == matrix[rows, cols + 1] 
                        && matrix[rows, cols] == matrix[rows + 1, cols] 
                        && matrix[rows, cols] == matrix[rows + 1, cols + 1])
                    {
                        counter++;
                    }    
                }
            }
            Console.WriteLine(counter);
        }
    }
}
