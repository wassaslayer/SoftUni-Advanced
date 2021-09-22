using System;
using System.Linq;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = ReadArrayFromConsole();
            int[,] matrix = new int[matrixSize[0], matrixSize[0]];
            for (int rows = 0; rows < matrixSize[0]; rows++)
            {
                int[] elements = ReadArrayFromConsole();
                for (int cols = 0; cols < matrixSize[0]; cols++)
                {
                    matrix[rows, cols] = elements[cols];
                }
            }
            int leftSide = 0;
            int rightSide = 0;
            for (int rows = 0; rows < matrixSize[0]; rows++)
            {
                leftSide += matrix[rows, rows];
            }
            for (int rows = 0; rows < matrixSize[0]; rows++)
            {
                rightSide += matrix[rows, matrixSize[0] - 1 - rows];
            }
            int sum = 0;
            if(leftSide > rightSide)
            {
                sum = leftSide - rightSide;
            }
            else
            {
                sum = rightSide - leftSide;
            }
            Console.WriteLine(sum);
        }

        private static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine().Split().Select(int.Parse).ToArray();
        }
    }
}
