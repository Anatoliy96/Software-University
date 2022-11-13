using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double orderPrice = 0;
            double totalPrice = 0;
            for (int i = 0; i < n; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());

                orderPrice = ((days * capsuleCount) * pricePerCapsule);

                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");

                totalPrice += orderPrice;
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
