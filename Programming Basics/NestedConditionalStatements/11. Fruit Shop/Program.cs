using System;

namespace _11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;
            double sum = 0;

            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
            {
                if (fruit == "banana")
                {
                    price += 2.50;
                    sum = quantity * price;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "apple")
                {
                    price += 1.20;
                    sum = quantity * price;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "orange")
                {
                    price += 0.85;
                    sum = quantity * price;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    price += 1.45;
                    sum = quantity * price;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "kiwi")
                {
                    price += 2.70;
                    sum = quantity * price;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "pineapple")
                {
                    price += 5.50;
                    sum = quantity * price;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "grapes")
                {
                    price += 3.85;
                    sum = quantity * price;
                    Console.WriteLine($"{sum:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                if (fruit == "banana")
                {
                    price += 2.70;
                    sum = quantity * price;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "apple")
                {
                    price += 1.25;
                    sum = quantity * price;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "orange")
                {
                    price += 0.90;
                    sum = quantity * price;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    price += 1.60;
                    sum = quantity * price;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "kiwi")
                {
                    price += 3.00;
                    sum = quantity * price;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "pineapple")
                {
                    price += 5.60;
                    sum = quantity * price;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "grapes")
                {
                    price += 4.20;
                    sum = quantity * price;
                    Console.WriteLine($"{sum:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
