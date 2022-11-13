using System;

namespace _02._Report_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amountFromSale = int.Parse(Console.ReadLine());
            string command;

            int sumInCash = 0;
            int sumInCreditCard = 0;
            int countOfPayment = 0;
            double countOfPaymentInCash = 0;
            double countOfPaymentInCreditCard = 0;
            int totalAmountOfMoney = 0;

            while ((command = Console.ReadLine()) != "End" && totalAmountOfMoney < amountFromSale)
            {
                int priceOfArticle = int.Parse(command);

                if (countOfPayment++ % 2 == 0)
                {
                    if (priceOfArticle > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        countOfPaymentInCash++;
                        sumInCash += priceOfArticle;
                        Console.WriteLine("Product sold!");
                    }
                }
                else
                {
                    if (priceOfArticle < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        countOfPaymentInCreditCard++;
                        sumInCreditCard += priceOfArticle;
                        Console.WriteLine("Product sold!");
                    }
                }
                totalAmountOfMoney = sumInCash + sumInCreditCard;
            }
            if (totalAmountOfMoney >= amountFromSale)
            {
                double averageSumInCash = sumInCash / countOfPaymentInCash;
                double averageSumInCreditCard = sumInCreditCard / countOfPaymentInCreditCard;
                Console.WriteLine($"Average CS: {averageSumInCash:f2}");
                Console.WriteLine($"Average CC: {averageSumInCreditCard:f2}");
            }
            else
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
