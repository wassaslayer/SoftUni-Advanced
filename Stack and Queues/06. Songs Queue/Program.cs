using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            Queue<string> queueSongs = new Queue<string>(songs);
            while(queueSongs.Count > 0)
            {
                string commands = Console.ReadLine();
                if(commands == "Play")
                {
                    queueSongs.Dequeue();
                }
                else if(commands == "Show")
                {
                    Console.WriteLine($"{string.Join(", ", queueSongs)}");
                }
                else
                {
                    int index = commands.IndexOf(' ');
                    string song = commands.Substring(index + 1);
                    if (queueSongs.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        queueSongs.Enqueue(song);
                    }
                }
            }
            Console.WriteLine($"No more songs!");
        }
    }
}
