using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split('|')
                .Reverse()
                .ToList();

            List<int> newNumbers = new List<int>();

            foreach (var number in numbers)
            {
                newNumbers.AddRange(number.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }

            Console.WriteLine(string.Join(" ", newNumbers));
        }
    }
}
