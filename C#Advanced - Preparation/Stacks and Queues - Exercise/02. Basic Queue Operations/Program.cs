using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] command = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<int> numbers = new Queue<int>();

            int n = command[0];
            int s = command[1];
            int x = command[2];

            int min = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                numbers.Enqueue(elements[i]);
            }

            for (int i = 0; i < s; i++)
            {
                numbers.Dequeue();
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            foreach (var item in numbers)
            {
                if (item == x)
                {
                    Console.WriteLine("true");
                    return;
                }
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
}
