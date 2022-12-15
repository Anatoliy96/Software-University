using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeopleWaiting = int.Parse(Console.ReadLine());

            int[] lift = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int capacity = 4;

            for (int i = 0; i < lift.Length; i++)
            {
                for (int j = lift[i]; j < 4; j++)
                {
                    lift[i]++;
                    numberOfPeopleWaiting--;

                    if (numberOfPeopleWaiting == 0)
                    {
                        if (lift.Sum() < lift.Length * capacity)
                        {
                            Console.WriteLine("The lift has empty spots!");
                        }

                        Console.WriteLine(string.Join(" ", lift));

                        return;
                    }
                }
            }
            Console.WriteLine($"There isn't enough space! {numberOfPeopleWaiting} people in a queue!");
            Console.WriteLine(string.Join(" ", lift));
        }
    }
}
