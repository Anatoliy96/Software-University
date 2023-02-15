using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int[] wagonState = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < wagonState.Length; i++)
            {
                while (wagonState[i] < 4 && peopleCount > 0)
                {
                    wagonState[i]++;
                    peopleCount--;
                }

                if (peopleCount == 0)
                {
                    break;
                }
            }

            bool liftIsFull = wagonState.All(wagon => wagon == 4);

            if (peopleCount == 0 && !liftIsFull)
            {
                Console.WriteLine("The lift has empty spots");
                Console.WriteLine(string.Join(" ", wagonState));
            }
            else if (peopleCount > 0 && liftIsFull)
            {
                Console.WriteLine($"There isn't enough space! {peopleCount} people in a queue!");
                Console.WriteLine(string.Join(" ", wagonState));
            }
            else
            {
                Console.WriteLine(string.Join(" ", wagonState));
            }
        }
    }
}
