using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split(new char[] {'|'}, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> result = new List<string>();

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                result = numbers[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int j = 0; j < result.Count; j++)
                {
                    Console.Write($"{result[j]} ");
                }
            }
        }
    }
}
