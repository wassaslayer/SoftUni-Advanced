using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = ReadArrayFromConsole();
            int[,] matrixElements = new int[rowsAndCols[0], rowsAndCols[1]];
            int sum = 0;
            for (int rows = 0; rows < rowsAndCols[0]; rows++)
            {
                int[] matrix = ReadArrayFromConsole();
                for (int cols = 0; cols < rowsAndCols[1]; cols++)
                {
                    matrixElements[rows, cols] = matrix[cols];
                    sum += matrixElements[rows, cols];
                }
            }
            foreach (var matrix in matrixElements)
            {
                Console.WriteLine(rowsAndCols[0]);
                Console.WriteLine(rowsAndCols[1]);
                Console.WriteLine(sum);
                break;
            }

        }

        private static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        }
    }
}
