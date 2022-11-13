using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int countOfCombinations = 0;
            int sum = 0;

            for (int i = startNumber; i <= endNumber; i++)
            {
                for (int j = startNumber; j <= endNumber; j++)
                {
                    sum = i + j;

                    countOfCombinations++;

                    if (sum == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{countOfCombinations} ({i} + {j} = {magicNumber})");
                        return;
                    }
                }
            }
            if (sum != magicNumber)
            {
                Console.WriteLine($"{countOfCombinations} combinations - neither equals {magicNumber}");
            }
        }
    }
}
