using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> stackOrders = new Queue<int>(orders);
            bool isComplete = true;
            int sum = 0;

                int biggestNumber = orders.Max();
            for (int i = 0; i < orders.Length; i++)
            {
                sum += orders[i];
                if (quantity >= sum)
                {
                    stackOrders.Dequeue();
                }
                if (quantity < sum)
                {
                    Console.WriteLine(biggestNumber);
                    Console.Write($"Orders left: ");
                    for (int j = 0; j < stackOrders.Count; j++)
                    {
                        Console.Write($"{stackOrders.Dequeue()} ");
                    }
                    isComplete = false;
                    Console.WriteLine();
                }
            }
            if (isComplete == true)
            {
                Console.WriteLine($"{biggestNumber}");
                Console.WriteLine($"Orders complete");
            }
        }
    }
}
