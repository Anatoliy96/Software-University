using System;

namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int maxNumber = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                sum += numbers;

                if (numbers > maxNumber)
                {
                    maxNumber = numbers;
                }
            }
            int sumWithoutMaxNumber = sum - maxNumber;

            if (maxNumber == sumWithoutMaxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + maxNumber);
            }
            else
            {
                int diff = Math.Abs(maxNumber - sumWithoutMaxNumber);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
    }
}
