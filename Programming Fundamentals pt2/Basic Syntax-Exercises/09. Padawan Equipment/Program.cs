using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The amount of money John has – floating - point number in the range[0.00…1000.00].

            double money = double.Parse(Console.ReadLine());

            //· The count of students – integer in the range[0…100].
            int countOfStudents = int.Parse(Console.ReadLine());
            //· The price of lightsabers for a single saber – floating - point number in the range[0.00…100.00].
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            //· The price of robes for a single robe – floating - point number in the range[0.00…100.00].
            double priceOfRobes = double.Parse(Console.ReadLine());
            //· The price of belts for a single belt – floating - point number in the range[0.00…100.00].
            double priceOfBelts = double.Parse(Console.ReadLine());

            double freeBelts = countOfStudents / 6;

            double students = Math.Ceiling((countOfStudents * 0.1) + countOfStudents);
            double sabersPrice = priceOfLightsabers * students;
            double robePrice = priceOfRobes * countOfStudents;
            double beltsPrice = priceOfBelts * (countOfStudents - freeBelts);

            double expenses = sabersPrice + robePrice + beltsPrice;

            if (expenses <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {expenses:f2}lv.");
            }
            else
            {
                double moneyNeeded = expenses - money;
                Console.WriteLine($"John will need {moneyNeeded:f2}lv more.");
            }
        }
    }
}
