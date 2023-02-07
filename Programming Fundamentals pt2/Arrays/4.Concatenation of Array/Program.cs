using System;
using System.Linq;

namespace _4.Concatenation_of_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            int[] concatenatedArray = new int[numbers.Length * 2];

            concatenatedArray = numbers.Concat(numbers).ToArray();

            Console.WriteLine(String.Join(",", concatenatedArray));
        }
    }
}
