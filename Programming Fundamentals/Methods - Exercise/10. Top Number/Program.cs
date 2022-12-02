
using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintTopNumbers(number);
        }

        static void PrintTopNumbers(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (IsDivisibleBy8(i) && HasOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool HasOddDigit(int number)
        {
            while (number != 0)
            {
                if ((number % 10) % 2 == 1)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }

        static bool IsDivisibleBy8(int number)
        {
            int sum = 0;
            
            while (number != 0) 
            {
                int nextNum = number % 10;

                sum += nextNum;

                nextNum -= number;
                number /= 10;
            }

            if (sum % 8 == 0)
            {
                return true;
            }

            return false;
        }
    }
}
