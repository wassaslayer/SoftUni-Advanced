using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[rowsAndCols[0], rowsAndCols[1]];
            for (int rows = 0; rows < rowsAndCols[0]; rows++)
            {
                string[] elements = Console.ReadLine().Split(" ");
                for (int cols = 0; cols < rowsAndCols[1]; cols++)
                {
                    matrix[rows, cols] = elements[cols];
                }
            }
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] commands = input.Split(" ");
                string swap = commands[0];
                if (commands.Length < 5)
                {
                    Console.WriteLine($"Invalid input!");
                }
                if (swap == "swap")
                {
                    int row1 = int.Parse(commands[1]);
                    int col1 = int.Parse(commands[2]);
                    int row2 = int.Parse(commands[3]);
                    int col2 = int.Parse(commands[4]);
                    if (row1 < 0 || row1 > rowsAndCols[0] || row2 < 0 || row2 > rowsAndCols[0] || col1 < 0 || col1 > rowsAndCols[1] || col2 < 0 || col2 > rowsAndCols[1])
                    {
                        Console.WriteLine($"Invalid input!");
                        input = Console.ReadLine();
                        continue;
                    }
                    string value = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = value;
                    for (int rows = 0; rows < rowsAndCols[0]; rows++)
                    {
                        for (int cols = 0; cols < rowsAndCols[1]; cols++)
                        {
                            Console.Write($"{matrix[rows, cols]} ");
                        }
                        Console.WriteLine();
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
