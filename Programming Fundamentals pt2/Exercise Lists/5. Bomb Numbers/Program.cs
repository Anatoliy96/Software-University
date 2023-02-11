using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            string[] tokens = command.Split();
            int specialNumber = int.Parse(tokens[0]);
            int power = int.Parse(tokens[1]);

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == specialNumber)
                {
                    int index = numbers.IndexOf(numbers[i]);
                    int start = Math.Max(0, index - power);
                    int end = Math.Min(numbers.Count - 1, index + power);

                    for (int j = start; j <= end; j++)
                    {
                        numbers[j] = 0;
                    }
                }
            }

            int sum = numbers.Sum();

            Console.WriteLine(sum);
        }
    }
}
