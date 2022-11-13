using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlowers = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double sum = 0;

            if (typeOfFlowers == "Roses")
            {
                sum = numberOfFlowers * 5.00;

                if (numberOfFlowers > 80)
                {
                    sum *= 0.90;
                }
                
            }
            else if (typeOfFlowers == "Dahlias")
            {
                sum = numberOfFlowers * 3.80;

                if (numberOfFlowers > 90)
                {
                    sum *= 0.85;
                }
            }
            else if (typeOfFlowers == "Tulips")
            {
                sum = numberOfFlowers * 2.80;

                if (numberOfFlowers > 80)
                {
                    sum *= 0.85;
                }
            }
            else if (typeOfFlowers == "Narcissus")
            {
                sum = numberOfFlowers * 3.00;

                if (numberOfFlowers < 120)
                {
                    sum *= 1.15;
                }
            }
            else if (typeOfFlowers == "Gladiolus")
            {
                sum = numberOfFlowers * 2.50;

                if (numberOfFlowers < 80)
                {
                    sum *= 1.20;
                }
            }

            if (budget >= sum)
            {
                double moneyLeft = budget - sum;
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeOfFlowers} and {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = sum - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.");
            }
        }
    }
}
