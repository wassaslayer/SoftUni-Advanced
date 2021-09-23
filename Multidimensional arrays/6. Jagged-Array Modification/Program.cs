using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[n][];
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArray[i] = elements;
            }
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] commands = input.Split();
                string action = commands[0];
                int row = int.Parse(commands[1]);
                int col = int.Parse(commands[2]);
                int value = int.Parse(commands[3]);
                if (row < 0 || row >= n || col < 0 || col > jaggedArray[row].Length)
                {
                    Console.WriteLine($"Invalid coordinates");
                    input = Console.ReadLine();
                    continue;
                }
                if (action == "Add")
                {
                    jaggedArray[row][col] += value;
                }
                else if (action == "Subtract")
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
    }
}
