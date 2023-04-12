using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();

            foreach (var num in numbers)
            {
                queue.Enqueue(num);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = queue.Dequeue();

                if ( currentNumber % 2 == 0)
                {
                    queue.Enqueue(currentNumber);
                }
            }
            Console.WriteLine(String.Join(", ", queue));
        }
    }
}
