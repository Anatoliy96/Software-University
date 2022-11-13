using System;

namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal change = decimal.Parse(Console.ReadLine());

            int coinsCount = 0;

            while (change != 0)
            {
                if (change >= 2.00m)
                {
                    change -= 2.00m;
                }
                else if (change >= 1.00m)
                {
                    change -= 1.00m;
                }
                else if (change >= 0.50m)
                {
                    change -= 0.50m;
                }
                else if (change >= 0.20m)
                {
                    change -= 0.20m;
                }
                else if (change >= 0.10m)
                {
                    change -= 0.10m;
                }
                else if (change >= 0.05m)
                {
                    change -= 0.05m;
                }
                else if (change >= 0.02m)
                {
                    change -= 0.02m;
                }
                else if (change >= 0.01m)
                {
                    change -= 0.01m;
                }
                coinsCount++;
            }
            Console.WriteLine(coinsCount);
        }
    }
}
