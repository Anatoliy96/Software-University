using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            SortedDictionary<int, int> counts = new SortedDictionary<int, int>();

            foreach (int number in numbers)
            {
                if (!counts.ContainsKey(number))
                {
                    counts.Add(number, 1);
                }
                else
                {
                    counts[number]++;
                }
            }

            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
