using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyForTrip = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            int daysCounter = 0;
            int spendingCounter = 0;

            while (availableMoney < moneyForTrip && spendingCounter < 5)
            {
                string action = Console.ReadLine();
                double sumForSaveOrSpend = double.Parse(Console.ReadLine());
                daysCounter++;

                if (action == "save")
                {
                    availableMoney += sumForSaveOrSpend;
                    spendingCounter = 0;
                }
                else if (action == "spend")
                {
                    availableMoney -= sumForSaveOrSpend;
                    spendingCounter++;

                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                }
            }
            if (spendingCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{daysCounter}");
            }
            else if (availableMoney >= moneyForTrip)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}
