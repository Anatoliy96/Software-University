using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int days = 0;
            int cosumePerDay = 26;
            int workesConsume = 0;
            int totalAmount = 0;

            if (startingYield >= 100)
            {
                while (startingYield >= 100)
                {
                    workesConsume = startingYield - cosumePerDay;

                    startingYield -= 10;

                    totalAmount += workesConsume;
                    days++;

                    if (totalAmount < 26)
                    {
                        continue;
                    }
                }

                totalAmount -= cosumePerDay;

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
