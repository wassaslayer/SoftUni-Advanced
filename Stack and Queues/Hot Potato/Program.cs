using System;
using System.Collections.Generic;
using System.Linq;

namespace Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine().Split(' ').ToArray();
            Queue<string> everyKid = new Queue<string>(children);
            int counter = int.Parse(Console.ReadLine());
            while(everyKid.Count > 1)
            {
                for (int i = 1; i < counter; i++)
                {
                    everyKid.Enqueue(everyKid.Dequeue());
                }
                Console.WriteLine($"Removed {everyKid.Dequeue()}");
            }
            Console.WriteLine($"Last is {everyKid.Dequeue()}");
        }
    }
}
