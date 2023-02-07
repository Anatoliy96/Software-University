using System;
using System.Linq;

namespace Shuffle_the_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int[] result = new int[2 * n];

            for (int i = 0; i < n; ++i)
            {
                result[2 * i] = numbers[i];
                result[2 * i + 1] = numbers[n + i];
            }

            Console.WriteLine($"[{string.Join(",", result)}]");
        }
    }
}
