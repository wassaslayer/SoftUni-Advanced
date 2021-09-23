using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
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
            int max = int.MinValue;
            for (int rows = 0; rows < rowsAndCols[0] - 1; rows++)
            {
                row = 0;
                col = 0;
                for (int cols = 0; cols < rowsAndCols[1] - 1; cols++)
                {
                    int sum = matrix[rows, cols] + matrix[rows, cols + 1] + matrix[rows + 1, cols] + matrix[rows + 1, cols + 1];
                    if (sum > max)
                    {
                        max = sum;
                        row = rows;
                        col = cols;
                    }
                }
            }
            Console.WriteLine($"{matrix[row, col]} {matrix[row, col + 1]}");
            Console.WriteLine($"{matrix[row + 1, col]} {matrix[row + 1, col + 1]}");
            Console.WriteLine(max);
        }

        private static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }
    }
}
