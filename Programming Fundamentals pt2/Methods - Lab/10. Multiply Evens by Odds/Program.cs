using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            GetMultipleOfEvenAndOdds(number);
        }

        static void GetMultipleOfEvenAndOdds(int sum)
        {
            Console.WriteLine(GetSumOfEvenDigits(sum) * GetSumOfOddDigits(sum));
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;

            number = Math.Abs(number);

            while (number > 0)
            {
                int lastDigit = number % 10;

                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }

                number /= 10;
            }

            return sum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;

            number = Math.Abs(number);

            while (number > 0)
            {
                int lastDigit = number % 10;

                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }

                number /= 10;
            }

            return sum;
        }
    }
}
