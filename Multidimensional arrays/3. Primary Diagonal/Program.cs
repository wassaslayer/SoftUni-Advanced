using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int sum = 0;
            for (int rows = 0; rows < n; rows++)
            {
                int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int cols = 0; cols < n; cols++)
                {
                    matrix[rows, cols] = elements[cols];
                }
            }
            for (int rows = 0; rows < n; rows++)
            {
                sum += matrix[rows, rows];
            }
            Console.WriteLine(sum);
        }
    }
}
