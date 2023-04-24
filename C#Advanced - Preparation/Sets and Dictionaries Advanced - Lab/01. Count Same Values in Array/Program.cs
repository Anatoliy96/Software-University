using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Dictionary<double, int> times = new Dictionary<double, int>();

            foreach (var num in numbers)
            {
                if (!times.ContainsKey(num))
                {
                    times.Add(num, 0);
                }

                times[num]++;
            }

            foreach (var item in times)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
