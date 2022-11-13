using System;

namespace _05._Average_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double numbersCount = 0;
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                sum += numbers;
                numbersCount++;
            }
            double average = sum / numbersCount;
            Console.WriteLine($"{average:f2}");
        }
    }
}
