using System;
using System.Collections.Generic;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(' ');

            Stack<string> stack = new Stack<string>();
            int result = 0;

            for (int i = 0; i < tokens.Length; i++)
            {
                stack.Push(tokens[i]);

                if (stack.Count == 3)
                {
                    int firstNumber = int.Parse(stack.Pop());
                    var operatation = stack.Pop();
                    int secondNumber = int.Parse(stack.Pop());

                    if (operatation == "+")
                    {
                        result = firstNumber + secondNumber;
                    }
                    else if (operatation == "-")
                    {
                        result = secondNumber - firstNumber;
                    }

                    stack.Push(result.ToString());
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
