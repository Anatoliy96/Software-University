using System;

namespace _10._Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int coinsOneLev = int.Parse(Console.ReadLine());
            int coinsTwoLev = int.Parse(Console.ReadLine());
            int cashFiveLev = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            int levCoin = 1;
            int levTwo = 2;
            int fiveCash = 5;

            int sumOfLev = 0;
            int sumOfTwoLev = 0;
            int sumOfFiveCash = 0;

            for (int i = 0; i <= coinsOneLev; i++)
            {
                for (int j = 0; j <= coinsTwoLev; j++)
                {

                    for (int k = 0; k <= cashFiveLev; k++)
                    {
                        sumOfLev = i * levCoin;
                        sumOfTwoLev = j * levTwo;
                        sumOfFiveCash = k * fiveCash;

                        if (sumOfLev + sumOfTwoLev + sumOfFiveCash == sum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }
        }
    }
}
