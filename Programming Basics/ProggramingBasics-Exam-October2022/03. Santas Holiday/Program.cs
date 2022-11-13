using System;

namespace _03._Santas_Holiday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysOfStay = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string grade = Console.ReadLine();

            if (roomType == "apartment")
            {
                double sumForApartment = (daysOfStay - 1) * 25.00;

                if (daysOfStay < 10)
                {
                    sumForApartment *= 0.70; 
                }
                else if (daysOfStay >= 10 && daysOfStay <= 15)
                {
                    sumForApartment *= 0.65;
                }
                else if (daysOfStay > 15)
                {
                    sumForApartment *= 0.50;
                }

                if (grade == "positive")
                {
                    sumForApartment *= 1.25;
                    Console.WriteLine($"{sumForApartment:f2}");
                }
                else if (grade == "negative")
                {
                    sumForApartment *= 0.9;
                    Console.WriteLine($"{sumForApartment:f2}");
                }
            }
            else if (roomType == "president apartment")
            {
                double sumForPresidentApartment = (daysOfStay - 1) * 35.00;

                if (daysOfStay < 10)
                {
                    sumForPresidentApartment *= 0.9;
                }
                else if (daysOfStay >= 10 && daysOfStay <= 15)
                {
                    sumForPresidentApartment *= 0.85;
                }
                else if (daysOfStay > 15)
                {
                    sumForPresidentApartment *= 0.80;
                }
                if (grade == "positive")
                {
                    sumForPresidentApartment *= 1.25;
                    Console.WriteLine($"{sumForPresidentApartment:f2}");
                }
                else if (grade == "negative")
                {
                    sumForPresidentApartment *= 0.9;
                    Console.WriteLine($"{sumForPresidentApartment:f2}");
                }
            }
            else if (roomType == "room for one person")
            {
                double sumForOnePerson = (daysOfStay - 1) * 18.00;

                if (grade == "positive")
                {
                    sumForOnePerson *= 1.25;
                    Console.WriteLine($"{sumForOnePerson:f2}");
                }
                else if (grade == "negative")
                {
                    sumForOnePerson *= 0.9;
                    Console.WriteLine($"{sumForOnePerson:f2}");
                }
            }
        }
    }
}
