using System;

namespace _08._Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (numbers > maxNumber)
                {
                    maxNumber = numbers;
                }
                if (numbers < minNumber)
                {
                    minNumber = numbers;
                }
            }
            Console.WriteLine("Max number:" + " " + maxNumber);
            Console.WriteLine("Min number:" + " " + minNumber);
        }
    }
}
