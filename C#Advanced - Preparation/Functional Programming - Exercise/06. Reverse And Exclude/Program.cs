using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int number = int.Parse(Console.ReadLine());

            List<int> result = numbers
                .Where(x => x % number != 0)
                .Reverse()
                .ToList();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
