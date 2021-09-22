using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {

            string parentheses = Console.ReadLine();
            Queue<string> queueParentheses = new Queue<string>();
            Stack<String> lastParentheses = new Stack<string>();
            int counter = 0;
            if(parentheses.Length == 0)
            {
                Console.WriteLine($"NO");
                return;
            }
            for (int i = 0; i < parentheses.Length/2; i++)
            {
                queueParentheses.Enqueue(parentheses[i].ToString());
            }
            for (int i = queueParentheses.Count; i < parentheses.Length; i++)
            {
                lastParentheses.Push(parentheses[i].ToString());
            }
            int start = queueParentheses.Count;
            for (int i = 0; i < start; i++)
            {
                string firstParenthese = queueParentheses.Peek();
                string secondParenthese = lastParentheses.Peek();
                if (firstParenthese == "{" && secondParenthese == "}")
                {
                    queueParentheses.Dequeue();
                    lastParentheses.Pop();
                }
                else if (firstParenthese == "[" && secondParenthese == "]")
                {
                    queueParentheses.Dequeue();
                    lastParentheses.Pop();
                }
                else if(firstParenthese =="(" && secondParenthese == ")")
                {
                    queueParentheses.Dequeue();
                    lastParentheses.Pop();
                }
            }
            if (lastParentheses.Count == 0)
            {
                Console.WriteLine($"YES");
            }
            else
            {
                Console.WriteLine($"NO");
            }
        }
    }
}
