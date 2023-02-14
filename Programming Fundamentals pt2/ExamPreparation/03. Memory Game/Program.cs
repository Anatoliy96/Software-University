using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = Console.ReadLine();
            int moves = 0;

            while (command != "end")
            {
                int[] tokens = command
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                int index1 = tokens[0];
                int index2 = tokens[1];

                moves++;

                if (index1 == index2 || index1 < 0 || index2 < 0 || index1 >= numbers.Count || index2 >= numbers.Count)
                {
                    int middleIndex = numbers.Count / 2;

                    numbers.Insert(middleIndex, $"-{moves}a");
                    numbers.Insert(middleIndex, $"-{moves}a");

                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (numbers[index1] == numbers[index2])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {numbers[index1]}!");

                    if (index1 > index2)
                    {
                        numbers.RemoveAt(index1);
                        numbers.RemoveAt(index2);
                    }
                    else
                    {
                        numbers.RemoveAt(index2);
                        numbers.RemoveAt(index1);
                    }

                }
                else if (numbers[index1] != numbers[index2])
                {
                    Console.WriteLine("Try again!");
                }
                if (numbers.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    break;
                }

                command = Console.ReadLine();
            }

            if (numbers.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
