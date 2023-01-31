using System;
using System.Linq;

namespace _06._Triple_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int sum = 0;

            bool containsTriples = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    sum = numbers[i] + numbers[j];

                    if (numbers.Contains(sum))
                    {
                        Console.WriteLine($"{numbers[i]} + {numbers[j]} == {sum}");
                        containsTriples = true;
                    }
                }
            }
            if (!containsTriples)
            {
                Console.WriteLine("No");
            }
        }
    }
}
