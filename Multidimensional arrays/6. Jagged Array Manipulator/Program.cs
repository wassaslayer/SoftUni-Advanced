using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] jaggedArray = new double[n][];
            for (int i = 0; i < n; i++)
            {
                double[] elements = Console.ReadLine().Split().Select(double.Parse).ToArray();
                jaggedArray[i] = elements;
            }
            for (int rows = 0; rows < n - 1; rows++)
            {
                if (jaggedArray[rows].Length == jaggedArray[rows + 1].Length)
                {
                    multiply(jaggedArray, rows);
                }
                else
                {
                    divide(jaggedArray, rows);
                }
            }
            string input = Console.ReadLine();
            while(input != "End")
            {
                string[] commands = input.Split(" ");
                if (commands.Length != 4)
                {
                    input = Console.ReadLine();
                    continue;
                }
                string action = commands[0];
                int row = int.Parse(commands[1]);
                int col = int.Parse(commands[2]);
                int value = int.Parse(commands[3]);
                if (row < 0 || row > n || col < 0 || col > jaggedArray[row].Length)
                {
                    input = Console.ReadLine();
                    continue;
                }
                if(action == "Add")
                {
                    jaggedArray[row][col] += value;
                }
                else if(action == "Subtract")
                {
                    jaggedArray[row][col] -= value;
                }
                input = Console.ReadLine();
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{String.Join(" ", jaggedArray[i])}");
            }
        }

        private static void multiply(double[][] jaggedArray, int rows)
        {
            for (int i = 0; i < jaggedArray[rows].Length; i++)
            {
                jaggedArray[rows][i] *= 2;
            }
            for (int i = 0; i < jaggedArray[rows + 1].Length; i++)
            {
                jaggedArray[rows + 1][i] *= 2;
            }
        }

        private static void divide(double[][] jaggedArray, int rows)
        {
            for (int i = 0; i < jaggedArray[rows].Length; i++)
            {
                jaggedArray[rows][i] /= 2;
            }
            for (int i = 0; i < jaggedArray[rows + 1].Length; i++)
            {
                jaggedArray[rows + 1][i] /= 2;
            }
        }
    }
}
