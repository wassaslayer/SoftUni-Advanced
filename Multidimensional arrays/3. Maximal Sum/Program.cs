using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = ReadArrayFromConsole();
            int[,] matrix = new int[rowsAndCols[0], rowsAndCols[1]];
            for (int rows = 0; rows < rowsAndCols[0]; rows++)
            {
                int[] elements = ReadArrayFromConsole();
                for (int cols = 0; cols < rowsAndCols[1]; cols++)
                {
                    matrix[rows, cols] = elements[cols];
                }
            }
            int row = 0;
            int col = 0;
            int sum = int.MinValue;
            for (int rows = 0; rows < rowsAndCols[0]-2; rows++)
            {
                for (int cols = 0; cols < rowsAndCols[1]-2; cols++)
                {
                    if(matrix[rows, cols] + matrix[rows, cols + 1]
                        + matrix[rows, cols + 2] + matrix[rows + 1, cols]
                        + matrix[rows + 1, cols + 1] + matrix[rows + 1, cols + 2]
                        + matrix[rows + 2, cols]
                        + matrix[rows + 2, cols + 1] + matrix[rows + 2, cols + 2] > sum)
                    {
                        sum = matrix[rows, cols] + matrix[rows, cols + 1]
                        + matrix[rows, cols + 2] + matrix[rows + 1, cols]
                        + matrix[rows + 1, cols + 1] + matrix[rows + 1, cols + 2]
                        + matrix[rows + 2, cols]
                        + matrix[rows + 2, cols + 1] + matrix[rows + 2, cols + 2];
                        row = rows;
                        col = cols;
                    }
                }
            }
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"{matrix[row, col]} {matrix[row, col + 1]} {matrix[row, col + 2]}{Environment.NewLine}{matrix[row + 1, col]} {matrix[row + 1, col + 1]} {matrix[row + 1, col + 2]}{Environment.NewLine}{matrix[row + 2, col]} {matrix[row + 2, col + 1]} {matrix[row + 2, col + 2]}");
        }

        private static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine().Split().Select(int.Parse).ToArray();
        }
    }
}
