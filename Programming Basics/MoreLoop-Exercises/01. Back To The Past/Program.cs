using System;

namespace _01._Back_To_The_Past
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int yearToSurvive = int.Parse(Console.ReadLine());

            int ageCount = 18;
            double moneySpend = 0;

            for (int i = 1800; i <= yearToSurvive; i++)
            {
                if (i % 2 == 0)
                {
                    money -= 12000;
                }
                else
                {
                    moneySpend = 12000 + ageCount * 50;
                    money -= moneySpend;
                }
                ageCount++;
            }
            if (money >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {money:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(money):f2} dollars to survive.");
            }
        }
    }
}
