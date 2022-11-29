using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            int result = GetMultipleOfEvenAndOdds(number);

            Console.WriteLine(result);
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            int result = GetSumOfEvenDigits(number) * GetSumOfOdds(number);

            return result;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sumOfEvens = 0;

            while (number != 0)
            {
                int nextNum = number % 10;

                if (nextNum % 2 == 0)
                {
                    sumOfEvens += nextNum;
                }

                nextNum -= number;
                number /= 10;
            }
            
            return sumOfEvens;
        }

        static int GetSumOfOdds(int number)
        {
            int sumOfOdds = 0;

            while (number != 0)
            {
                int nextNum = number % 10;

                if (nextNum % 2 == 1)
                {
                    sumOfOdds += nextNum;
                }

                nextNum -= number;
                number /= 10;
            }
            
            return sumOfOdds;
        }
    }
}
