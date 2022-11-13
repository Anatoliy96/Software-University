using System;

namespace _06._Bills
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfMounts = int.Parse(Console.ReadLine());

            double billForElectricity = 0;
            double billForWater = 0;
            double billForInternet = 0;
            double otherBills = 0;
            double totalOtherBills = 0;
            double priceOfWater = 20;
            double priceOfInternet = 15;

            for (int i = 0; i < numberOfMounts; i++)
            {
                double current = double.Parse(Console.ReadLine());

                billForElectricity += current;
                billForWater = numberOfMounts * priceOfWater;
                billForInternet = numberOfMounts * priceOfInternet;
                otherBills = (current + priceOfWater + priceOfInternet) * 1.20;
                totalOtherBills += otherBills;
            }

            double average = (billForElectricity + billForWater + billForInternet + totalOtherBills) / numberOfMounts;

            Console.WriteLine($"Electricity: { billForElectricity:f2} lv");
            Console.WriteLine($"Water: {billForWater:f2} lv");
            Console.WriteLine($"Internet: {billForInternet:f2} lv");
            Console.WriteLine($"Other: {totalOtherBills:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}
