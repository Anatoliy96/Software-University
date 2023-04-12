using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();

            foreach (var num in numbers)
            {
                stack.Push(num);
            }

            string[] command = Console.ReadLine().ToLower().Split(' ');

            while (command[0] != "end")
            {
                if (command[0] == "add")
                {
                    int firstNumber = int.Parse(command[1]);
                    int secondNumber = int.Parse(command[2]);

                    stack.Push(firstNumber);
                    stack.Push(secondNumber);
                }
                else if (command[0] == "remove")
                {
                    int n = int.Parse(command[1]);

                    if (stack.Count >= n)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                command = Console.ReadLine().ToLower().Split(' ');
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
