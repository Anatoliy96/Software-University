using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());


            double result = OrdersPrice(product, quantity);

            Console.WriteLine($"{result:f2}");
        }

        static double OrdersPrice(string product, double quantity)
        {
            double result = 0;

            if (product == "coffee")
            {
                result = quantity * 1.50;
            }
            else if (product == "water")
            {
                result = quantity * 1.00;
            }
            else if (product == "coke")
            {
                result = quantity * 1.40;
            }
            else if (product == "snacks")
            {
                result = quantity * 2.00;
            }

            return result;
        }
    }
}
