using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] stackOperations = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();
            int n = stackOperations[0];
            int x = stackOperations[1];
            int s = stackOperations[2];
            for (int i = 0; i < n; i++)
            {
                stack.Push(numbers[i]);
            }
            for (int i = 0; i < x; i++)
            {
                stack.Pop();
            }
            if (stack.Count == 0)
            {
                Console.WriteLine($"0");
                return;
            }
            if (stack.Contains(s))
            {
                Console.WriteLine($"true");
            }
            else
            {
                Console.WriteLine($"{stack.Min()}");
            }
        }
    }
}
