using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> maxAndMin = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                int[] commands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int action = commands[0];
                if (action == 1)
                {
                    int number = commands[1];
                    maxAndMin.Push(number);
                }
                if (maxAndMin.Count > 0)
                {
                    if (action == 2)
                    {
                        maxAndMin.Pop();
                    }
                    else if (action == 3)
                    {
                        Console.WriteLine(maxAndMin.Max());
                    }
                    else if (action == 4)
                    {
                        Console.WriteLine(maxAndMin.Min());
                    }
                }
            }

            Console.WriteLine(string.Join(", ", maxAndMin));
        }
    }
}
