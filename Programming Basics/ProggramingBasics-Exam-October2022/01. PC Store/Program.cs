using System;

namespace _01._PC_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceOfCPU = double.Parse(Console.ReadLine());
            double priceOfVideoCard = double.Parse(Console.ReadLine());
            double ram = double.Parse(Console.ReadLine());
            int numberOfRam = int.Parse(Console.ReadLine());
            double percentDiscount = double.Parse(Console.ReadLine());

            double priceOfCPUInLeva = priceOfCPU * 1.57;
            double priceOfVideoCardInLeva = priceOfVideoCard * 1.57;
            double priceOfRamInLeva = ram * 1.57;
            priceOfRamInLeva *= numberOfRam;
            double priceOfCPUAfterDiscount = priceOfCPUInLeva - (priceOfCPUInLeva * percentDiscount);
            double priceOfVideoCardAfterDiscount = priceOfVideoCardInLeva - (priceOfVideoCardInLeva * percentDiscount);
            double totalPrice = priceOfCPUAfterDiscount + priceOfVideoCardAfterDiscount + priceOfRamInLeva;

            Console.WriteLine($"Money needed - {totalPrice:f2} leva.");

        }
    }
}
