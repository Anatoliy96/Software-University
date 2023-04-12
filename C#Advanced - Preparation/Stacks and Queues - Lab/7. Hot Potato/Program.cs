using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();

            foreach (var item in input)
            {
                queue.Enqueue(item);
            }

            int turn = 1;

            while (queue.Count > 1)
            {
                string currentKid = queue.Dequeue();

                if (turn == n)
                {
                    Console.WriteLine($"Removed {currentKid}");
                    turn = 1;
                    continue;
                }

                queue.Enqueue(currentKid);
                turn++;
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
