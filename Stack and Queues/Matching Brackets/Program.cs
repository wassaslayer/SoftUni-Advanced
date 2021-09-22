using System;
using System.Collections.Generic;
using System.Linq;

namespace Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> matchingBrackets = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] == '(')
                {
                    matchingBrackets.Push(i);
                }
                else if(input[i] == ')')
                {
                    int index = matchingBrackets.Pop();
                    Console.WriteLine($"{input.Substring(index, i - index + 1)}");
                }
            }

        }
    }
}
