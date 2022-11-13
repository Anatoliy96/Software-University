using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sumOfNumber = 0;

            while (sumOfNumber < number)
            {
                int numbers = int.Parse(Console.ReadLine());

                sumOfNumber += numbers;
            }
            Console.WriteLine(sumOfNumber);
        }
    }
}
