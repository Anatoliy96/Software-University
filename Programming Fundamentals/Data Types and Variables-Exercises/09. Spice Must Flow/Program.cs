using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int days = 0;
            int totalAmount = 0;
            int consumePerDay = 26;
            int workersConsume = 0;

            if (startingYield >= 100)
            {
                while (startingYield >= 100)
                {
                    workersConsume = startingYield - consumePerDay;

                    startingYield -= 10;

                    totalAmount += workersConsume;
                    days++;

                    if (totalAmount < 26)
                    {
                        continue;
                    }
                }
                totalAmount -= consumePerDay;

                Console.WriteLine($"{days}");
                Console.WriteLine($"{totalAmount}");

            }
            else
            {
                Console.WriteLine($"{days}");
                Console.WriteLine($"{totalAmount}");
            }
        }
    }
}
