using System;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                int number = int.Parse(command);

                if (!IsPalindrome(number))
                {
                    Console.WriteLine("false");
                }
                else
                {
                    Console.WriteLine("true");
                }
            }
        }

        static bool IsPalindrome(int number)
        {
            int lastDigit = number % 10;
            int firstDigit = 0;

            while (number >= 10)
            {
                number = number / 10;
                firstDigit = number;
            }
            
            if (firstDigit == lastDigit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
