﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int[]> petrolPumps = new Queue<int[]>();
            int countOfPetrolPumps = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfPetrolPumps; i++)
            {
                int[] petrolPump = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                petrolPumps.Enqueue(petrolPump);
            }
            int index = 0;
            while (true)
            {
                int totalFuel = 0;
                foreach (int[] petrolPump in petrolPumps)
                {
                    int petrolAmount = petrolPump[0];
                    int distance = petrolPump[1];
                    totalFuel += petrolAmount - distance;
                    if (totalFuel < 0)
                    {
                        petrolPumps.Enqueue(petrolPumps.Dequeue());
                        index++;
                        break;
                    }
                }
                if(totalFuel>=0)
                {
                    Console.WriteLine(index);
                    break;
                }
            }
        }
    }
}
