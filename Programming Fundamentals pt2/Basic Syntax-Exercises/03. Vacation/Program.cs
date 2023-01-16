using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;
            double totalPrice = 0;

            if (day == "Friday")
            {
                if (typeOfGroup == "Students")
                {
                    price = 8.45;
                    totalPrice = countOfPeople * price;

                    if (countOfPeople >= 30)
                    {
                        totalPrice *= 0.85;
                    }
                }
                else if (typeOfGroup == "Business")
                {
                    price = 10.90;
                    totalPrice = countOfPeople * price;

                    if (countOfPeople >= 100)
                    {
                        totalPrice -= (price * 10);
                    }
                }
                else if (typeOfGroup == "Regular")
                {
                    price = 15;
                    totalPrice = countOfPeople * price;

                    if (countOfPeople >= 10 && countOfPeople <= 20)
                    {
                        totalPrice *= 0.95;
                    }
                }
            }
            else if (day == "Saturday")
            {
                if (typeOfGroup == "Students")
                {
                    price = 9.80;
                    totalPrice = countOfPeople * price;

                    if (countOfPeople >= 30)
                    {
                        totalPrice *= 0.85;
                    }
                }
                else if (typeOfGroup == "Business")
                {
                    price = 15.60;
                    totalPrice = countOfPeople * price;

                    if (countOfPeople >= 100)
                    {
                        totalPrice -= (price * 10);
                    }
                }
                else if (typeOfGroup == "Regular")
                {
                    price = 20;
                    totalPrice = countOfPeople * price;

                    if (countOfPeople >= 10 && countOfPeople <= 20)
                    {
                        totalPrice *= 0.95;
                    }
                }
            }
            else if (day == "Sunday")
            {
                if (typeOfGroup == "Students")
                {
                    price = 10.46;
                    totalPrice = countOfPeople * price;

                    if (countOfPeople >= 30)
                    {
                        totalPrice *= 0.85;
                    }
                }
                else if (typeOfGroup == "Business")
                {
                    price = 16;
                    totalPrice = countOfPeople * price;

                    if (countOfPeople >= 100)
                    {
                        totalPrice -= (price * 10);
                    }
                }
                else if (typeOfGroup == "Regular")
                {
                    price = 22.50;
                    totalPrice = countOfPeople * price;

                    if (countOfPeople >= 10 && countOfPeople <= 20)
                    {
                        totalPrice *= 0.95;
                    }
                }
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
