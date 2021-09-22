using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> stackedNumbers = new Stack<int>(numbers);
            string input = Console.ReadLine().ToUpper();
            while(input != "END")
            {
                string[] commands = input.Split(" ");
                string action = commands[0];
                if(action == "ADD")
                {
                    int number1 = int.Parse(commands[1]);
                    int number2 = int.Parse(commands[2]);
                    stackedNumbers.Push(number1);
                    stackedNumbers.Push(number2);
                }
                else if(action == "REMOVE")
                {
                    int numberForRemove = int.Parse(commands[1]);
                    if(stackedNumbers.Count < numberForRemove)
                    {

                    }
                    else
                    {
                        for (int i = 0; i < numberForRemove; i++)
                        {
                            stackedNumbers.Pop();
                        }
                    }
                }
                input = Console.ReadLine().ToUpper();
            }
            Console.WriteLine($"Sum: {stackedNumbers.Sum()}");
        }
    }
}
