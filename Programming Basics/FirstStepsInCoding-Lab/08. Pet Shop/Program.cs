using System;

namespace _08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());

            double priceForDogFood = 2.50;
            double priceForCarFood = 4;

            double costForFood = dogFood * priceForDogFood + catFood * priceForCarFood;

            Console.WriteLine($"{costForFood} lv.");
        }
    }
}
