using System;

namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal change = decimal.Parse(Console.ReadLine());

            int countOfCoints = 0;

            while (change > 0)
            {
                if (change >= 2.00m)
                {
                    change -= 2.00m;
                    countOfCoints++;
                }
                else if (change >= 1.00m)
                {
                    Math.Round(change -= 1.00m);
                    countOfCoints++;
                }
                else if (change >= 0.50m)
                {
                    change -= 0.50m;
                    countOfCoints++;
                }
                else if (change >= 0.20m)
                {
                    change -= 0.20m;
                    countOfCoints++;
                }
                else if (change >= 0.10m)
                {
                    change -= 0.10m;
                    countOfCoints++;
                }
                else if (change >= 0.05m)
                {
                    change -= 0.05m;
                    countOfCoints++;
                }
                else if (change >= 0.02m)
                {
                    change -= 0.02m;
                    countOfCoints++;
                }
                else if (change >= 0.01m)
                {
                    change -= 0.01m;
                    countOfCoints++;
                }
            }
            Console.WriteLine(countOfCoints);
        }
    }
}
