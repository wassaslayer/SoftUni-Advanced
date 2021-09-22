using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] queueOperations = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();
            int n = queueOperations[0];
            int s = queueOperations[1];
            int x = queueOperations[2];
            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }
            if (queue.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }
            else if (queue.Contains(x))
            {
                Console.WriteLine($"true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
