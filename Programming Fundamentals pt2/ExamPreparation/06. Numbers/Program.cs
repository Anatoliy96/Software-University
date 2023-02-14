using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> topNumbers = new List<int>();

            double sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            double averageNumber = sum / numbers.Count;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > averageNumber)
                {
                    topNumbers.Add(numbers[i]);
                }
            }

            if (topNumbers.Count == 0)
            {
                Console.WriteLine("No");
            }
            else if (topNumbers.Count >= 5)
            {
                topNumbers = topNumbers.OrderByDescending(t => t).Take(5).ToList();
                Console.WriteLine(String.Join(" ", topNumbers));
            }
            else
            {
                topNumbers = topNumbers.OrderByDescending((t) => t).ToList();
                Console.WriteLine(String.Join(" ", topNumbers));
            }
        }
    }
}
