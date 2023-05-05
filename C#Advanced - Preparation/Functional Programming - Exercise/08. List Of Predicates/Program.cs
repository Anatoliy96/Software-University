using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._List_Of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Predicate<int>> predicates = new List<Predicate<int>>();
            int endOfRange = int.Parse(Console.ReadLine());

            HashSet<int> dividers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToHashSet();

            foreach (var divider in dividers)
            {
                predicates.Add(n => n % divider == 0);
            }

            int[] numbers = Enumerable.Range(1, endOfRange).ToArray();

            foreach (var number in numbers)
            {
                bool isDivisible = true;

                foreach (var match in predicates)
                {
                    if (!match(number))
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    Console.Write($"{number + " "}");
                }
            }
        }
    }
}
