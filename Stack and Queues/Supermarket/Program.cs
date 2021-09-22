using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();
            int counter = 0;
            string input = Console.ReadLine();
            while(input != "End")
            {
                if(input == "Paid")
                {
                    for (int i = 0; i < names.Count; i++)
                    {
                        Console.WriteLine(names.Dequeue());
                        i--;
                    }
                    counter = 0;
                }
                else
                {
                    names.Enqueue(input);
                    counter++;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{counter} people remaining.");
        }
    }
}
