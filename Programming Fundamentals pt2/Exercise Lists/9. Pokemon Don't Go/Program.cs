using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            while (numbers.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                int removedElemenet = 0;

                int lastElement = numbers[numbers.Count - 1];
                int firstElement = numbers[0];

                if (index < 0)
                {
                    removedElemenet = firstElement;
                    numbers.RemoveAt(0);
                    numbers.Insert(0, lastElement);
                }
                else if (index > numbers.Count - 1)
                {
                    removedElemenet = lastElement;
                    numbers.RemoveAt(numbers.Count - 1);
                    numbers.Add(firstElement);
                }
                else
                {
                    removedElemenet = numbers[index];
                    numbers.RemoveAt(index);
                }

                result.Add(removedElemenet);

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= removedElemenet)
                    {
                        numbers[i] += removedElemenet;
                    }
                    else
                    {
                        numbers[i] -= removedElemenet;
                    }
                }

            }
            Console.WriteLine(string.Join(" ", result.Sum()));
        }
    }
}
