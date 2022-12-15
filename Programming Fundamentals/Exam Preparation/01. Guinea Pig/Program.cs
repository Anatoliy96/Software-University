using System;

namespace _01._Guinea_Pig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double quantityFoodInKilograms = double.Parse(Console.ReadLine()) * 1000;
            double quantityHayInKilograms = double.Parse(Console.ReadLine()) * 1000;
            double quantityCoverInKilograms = double.Parse(Console.ReadLine()) * 1000;
            double guineaWeightInKilograms = double.Parse(Console.ReadLine()) * 1000;

      
            for (int i = 1; i <= 30; i++)
            {
                quantityFoodInKilograms -= 300;

                if (i % 2 == 0)
                {
                    double hayNeeded = quantityFoodInKilograms * 0.05;
                    quantityHayInKilograms -= hayNeeded;
                }

                if (i % 3 == 0)
                {
                    quantityCoverInKilograms -= guineaWeightInKilograms / 3;
                }

                if (quantityFoodInKilograms <= 0 || quantityCoverInKilograms <= 0 || quantityHayInKilograms <= 0)
                {
                    break;
                }
            }

            quantityFoodInKilograms /= 1000;
            quantityHayInKilograms /= 1000;
            quantityCoverInKilograms /= 1000;

            if (quantityFoodInKilograms <= 0 || quantityCoverInKilograms <= 0 || quantityHayInKilograms <= 0)
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
            else
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {quantityFoodInKilograms:f2}," +
                    $" Hay: {quantityHayInKilograms:f2}, Cover: {quantityCoverInKilograms:f2}.");
            }
        }
    }
}
