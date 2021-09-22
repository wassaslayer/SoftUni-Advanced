using System;
using System.Collections.Generic;
namespace Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            string input = Console.ReadLine();
            int counter = 0;
            while(input != "end")
            {
                if(input == "green")
                {
                    if(n > cars.Count)
                    {
                        n = cars.Count;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        counter++;
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
