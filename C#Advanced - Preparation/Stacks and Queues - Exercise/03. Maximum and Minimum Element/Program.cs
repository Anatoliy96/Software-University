using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> numbers = new Stack<int>();

            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (command[0] == 1)
                {
                    int numToPush = command[1];

                    numbers.Push(numToPush);
                }
                else if (command[0] == 2)
                {
                    numbers.Pop();
                }
                else if (command[0] == 3)
                {
                    if (numbers.Count == 0)
                    {
                        continue;
                    }

                    foreach (var item in numbers)
                    {
                        if (item > max)
                        {
                            max = item;
                        }
                    }
                    Console.WriteLine(max);
                }
                else if (command[0] == 4)
                {
                    if (numbers.Count == 0)
                    {
                        continue;
                    }

                    foreach (var item in numbers)
                    {
                        if (item < min)
                        {
                            min = item;
                        }
                    }
                    Console.WriteLine(min);
                }
            }

            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}
