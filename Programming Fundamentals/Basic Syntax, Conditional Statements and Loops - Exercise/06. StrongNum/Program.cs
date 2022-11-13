using System;

namespace _06._StrongNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int input = n;
            int sum = 0;

            while (n > 0)
            {
                int number = n % 10;
                int factorial = 1;

                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }

                sum += factorial;
                n /= 10;
            }

            if (sum == input)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
