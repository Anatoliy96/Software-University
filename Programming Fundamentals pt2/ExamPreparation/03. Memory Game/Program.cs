using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split(' ').ToList();

            string command = Console.ReadLine();
            int moves = 0;

            while (command != "end")
            {
                string[] tokens = command.Split();
                int num1 = int.Parse(tokens[0]);
                int num2 = int.Parse(tokens[1]);

                if (num1 == num2 && num1 < 0 && num2 < 0 && num1 > numbers.Count && num2 > numbers.Count)
                {
                    moves++;

                    numbers.Insert(numbers.Count / 2, $"-{moves}a");

                }
            }
        }
    }
}
