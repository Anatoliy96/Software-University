using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyForExcursion = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            int spendCount = 0;
            int daysCount = 0;
            bool isMoneyEnough = false;

            while (availableMoney < moneyForExcursion && spendCount < 5)
            {
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());

                daysCount++;

                if (action == "save")
                {
                    availableMoney += money;

                    spendCount = 0;
                    if (availableMoney >= moneyForExcursion)
                    {
                        isMoneyEnough = true;
                        break;
                    }
                }
                else if (action == "spend")
                {
                    availableMoney -= money;

                    spendCount++;

                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                }
            }

            if (isMoneyEnough)
            {
                Console.WriteLine($"You saved the money for {daysCount} days.");
            }
            else
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCount);
            }
        }
    }
}
