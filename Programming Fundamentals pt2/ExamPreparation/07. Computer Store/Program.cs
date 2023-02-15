using System;

namespace _07._Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            double totalPrice = 0;
            
            while ((command = Console.ReadLine()) != "special" && command != "regular") 
            {
                double prices = double.Parse(command);

                if (prices < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }

                totalPrice += prices;
            }

            double taxes = totalPrice * 0.20;
            

            if (totalPrice > 0)
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");

                totalPrice += taxes;

                if (command == "special")
                {
                    double discount = totalPrice * 0.90;
                    Console.WriteLine($"Total price: {discount:f2}$");
                }
                else
                {
                    Console.WriteLine($"Total price: {totalPrice:f2}$");
                }
            }
            else
            {
                Console.WriteLine("Invalid order!");
            }
        }
    }
}
