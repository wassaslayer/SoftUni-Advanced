using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, n];
            for (int rows = 0; rows < n; rows++)
            {
                string elements = Console.ReadLine();
                for (int cols = 0; cols < n; cols++)
                {
                        matrix[rows, cols] = elements[cols].ToString();
                    matrix[rows, cols] = elements[cols].ToString();
                }
            }
            string element = Console.ReadLine();
            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    if (matrix[rows, cols].Contains(element))
                    {
                        Console.WriteLine($"({rows}, {cols})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{element} does not occur in the matrix");
        }
    }
}
