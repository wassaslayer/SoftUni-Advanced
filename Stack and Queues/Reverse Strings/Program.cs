﻿using System;
using System.Collections.Generic;

namespace Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> reversedString = new Stack<char>();
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                reversedString.Push(input[i]);
            }
            while (reversedString.Count > 0)
            {
                Console.Write(reversedString.Pop());
            }
        }
    }
}
