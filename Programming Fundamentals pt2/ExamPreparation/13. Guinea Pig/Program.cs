using System;

namespace _13._Guinea_Pig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double quantityFood = double.Parse(Console.ReadLine()) * 1000;
            double quantityHay = double.Parse(Console.ReadLine()) * 1000;
            double quantityCover = double.Parse(Console.ReadLine()) * 1000;
            double guineaWeight = double.Parse(Console.ReadLine()) * 1000;

            for (int i = 1; i <= 30; i++)
            {
                quantityFood -= 300;

                if (i % 2 == 0)
                {
                    double percentigeFood = quantityFood * 0.05;
                    quantityHay -= percentigeFood;
                }
                if (i % 3 == 0)
                {
                    double cover = guineaWeight / 3;
                    quantityCover -= cover;
                }
                if (quantityCover <= 0 || quantityFood <= 0 || quantityHay <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
            }
            quantityFood /= 1000;
            quantityHay /= 1000;
            quantityCover /= 1000;

            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {quantityFood:f2}, Hay: {quantityHay:f2}, Cover: {quantityCover:f2}.");
        }
    }
}
