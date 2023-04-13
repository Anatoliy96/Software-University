using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(clothes);

            int sum = 0;
            int count = 1;

            while (stack.Count > 0)
            {
                while (sum < capacity)
                {
                    sum += stack.Peek();

                    if (sum > capacity)
                    {
                        sum -= stack.Peek();
                        count++;
                        sum = 0;
                        continue;
                    }
                    stack.Pop();

                    if (stack.Count == 0)
                    {
                        break;
                    }
                }

                if (sum == capacity)
                {
                    if (stack.Count > 0)
                    {
                        count++;
                        sum = 0;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
