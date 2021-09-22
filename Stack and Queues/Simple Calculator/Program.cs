using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').Reverse().ToArray();
            Stack<string> calculator = new Stack<string>(input);
            while(calculator.Count > 1)
            {
                string number1 = calculator.Pop();
                string plusOrMinus = calculator.Pop();
                string number2 = calculator.Pop();
                if(plusOrMinus == "-")
                {
                    int sum = int.Parse(number1) - int.Parse(number2);
                    calculator.Push(sum.ToString());
                }
                if(plusOrMinus == "+")
                {
                    int sum = int.Parse(number1) + int.Parse(number2);
                    calculator.Push(sum.ToString());
                }
            }
            Console.WriteLine(calculator.Pop());
        }
    }
}
