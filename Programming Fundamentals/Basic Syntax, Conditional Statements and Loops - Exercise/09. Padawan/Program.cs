using System;

namespace _09._Padawan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightSabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            double freeBelts = countOfStudents / 6;

            double students = Math.Ceiling((countOfStudents * 0.1) + countOfStudents);
            double sabersPrice = priceOfLightSabers * students;
            double robePrice = priceOfRobes * countOfStudents;
            double beltsPrice = priceOfBelts * (countOfStudents - freeBelts);

           
            
            double totalMoney = sabersPrice + robePrice + beltsPrice;

            if (totalMoney <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoney:f2}lv.");
            }
            else
            {
                double moneyNeeded = totalMoney - amountOfMoney;
                Console.WriteLine($"John will need {moneyNeeded:f2}lv more.");
            }
        }
    }
}
