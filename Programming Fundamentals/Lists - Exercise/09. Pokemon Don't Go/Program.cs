using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> removedNumbers = new List<int>();
            int removedNumber = 0;

            while (numbers.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    removedNumber = numbers[0];
                    removedNumbers.Add(removedNumber);
                    numbers.RemoveAt(0);
                    numbers.Insert(0, numbers[numbers.Count - 1]);
                }
                else if (index > numbers.Count - 1)
                {
                    removedNumber = numbers[numbers.Count - 1];
                    removedNumbers.Add(removedNumber);
                    numbers.RemoveAt(numbers.Count - 1);
                    numbers.Add(numbers[0]);
                }
                else
                {
                    removedNumber = numbers[index];
                    removedNumbers.Add(removedNumber);
                    numbers.RemoveAt(index);
                }

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= removedNumber)
                    {
                        numbers[i] += removedNumber;
                    }
                    else if (numbers[i] > removedNumber)
                    {
                        numbers[i] -= removedNumber;
                    }
                }

            }

            Console.WriteLine(removedNumbers.Sum());
        }
    }
}
