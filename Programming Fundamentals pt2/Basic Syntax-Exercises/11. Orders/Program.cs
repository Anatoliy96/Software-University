using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            
            double priceOfCoffee = 0;
            double totalPrice = 0;

            for (int i = 0; i < orders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());

                priceOfCoffee = ((days * capsuleCount) * pricePerCapsule);
                totalPrice += priceOfCoffee;

                Console.WriteLine($"The price for the coffee is: ${priceOfCoffee:f2}");

                priceOfCoffee = 0;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
