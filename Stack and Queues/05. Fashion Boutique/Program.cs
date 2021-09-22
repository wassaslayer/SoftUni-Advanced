using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> stackClothes = new Stack<int>(clothes);
            int capacity = int.Parse(Console.ReadLine());
            int savedCapacity = capacity;
            int counter = 1;
            while(stackClothes.Count > 0)
            {
                int sum = stackClothes.Peek();
                if (capacity >= sum)
                {
                    capacity -= sum;
                    stackClothes.Pop();
                }
                else if(capacity < sum)
                {
                    capacity = savedCapacity;
                    counter++;
                }

            }
            Console.WriteLine($"{counter}");
        }
    }
}
