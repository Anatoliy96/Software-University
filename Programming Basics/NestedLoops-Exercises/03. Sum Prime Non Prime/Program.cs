using System;

namespace _03._Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;

            int priemSum = 0;
            int nonPrimeSum = 0;

            while ((command = Console.ReadLine()) != "stop")
            {
                int num = int.Parse(command);

                bool isPrime = true;

                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                for (int i = 2; i < num; i++)
                {
                    int remainder = num % i;

                    if (remainder == 0)
                    {
                        nonPrimeSum += num;
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    priemSum += num;
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {priemSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
