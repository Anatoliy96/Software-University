using System;

namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //· Брой пакети химикали - цяло число в интервала[0...100]
            int numberOfChemicals = int.Parse(Console.ReadLine());
            //· Брой пакети маркери - цяло число в интервала[0...100]
            int numberOfMarkers = int.Parse(Console.ReadLine());
            //· Литри препарат за почистване на дъска -цяло число в интервала[0…50]
            int litresOfBoardCleaner = int.Parse(Console.ReadLine());
            //· Процент намаление -цяло число в интервала[0...100]
            int percentDiscount = int.Parse(Console.ReadLine());

            //• Пакет химикали -5.80 лв.

            //• Пакет маркери -7.20 лв.

            //• Препарат - 1.20 лв(за литър)
            double packageChemicals = 5.80;
            double packageMarkers = 7.20;
            double medication = 1.20;

            double priceForChemicals = numberOfChemicals * packageChemicals;
            double priceForMarkers = numberOfMarkers * packageMarkers;
            double priceForMedication = litresOfBoardCleaner * medication;

            double priceForAllMaterials = priceForChemicals + priceForMarkers + priceForMedication;
            double discount = percentDiscount / 100.0 * priceForAllMaterials;

            double price = priceForAllMaterials - discount;

            Console.WriteLine(price);
        }
    }
}
