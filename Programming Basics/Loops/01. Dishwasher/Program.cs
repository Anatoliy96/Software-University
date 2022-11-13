using System;

namespace _01._Dishwasher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int preparationBottles = int.Parse(Console.ReadLine());
            string command;

            int bottleQuantity = 750;
            int preparationForOneDish = 5;
            int preparationForOnePot = 15;

            int numberOfDishes = 0;
            int numberOfPots = 0;
            int chargeCount = 0;

            int amountOfPreparation = preparationBottles * bottleQuantity;

            while ((command = Console.ReadLine()) != "End")
            {
                int numberOfVessels = int.Parse(command);

                chargeCount++;

                if (chargeCount % 3 == 0)
                {
                    numberOfPots += numberOfVessels;
                    numberOfVessels *= preparationForOnePot;
                }

                else
                {
                    numberOfDishes += numberOfVessels;
                    numberOfVessels *= preparationForOneDish;
                }

                if (amountOfPreparation < numberOfVessels)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(amountOfPreparation -= numberOfVessels)} ml. more necessary!");
                    return;
                }

                amountOfPreparation -= numberOfVessels;
            }
            Console.WriteLine("Detergent was enough!");
            Console.WriteLine($"{numberOfDishes} dishes and {numberOfPots} pots were washed.");
            Console.WriteLine($"Leftover detergent {amountOfPreparation} ml.");
        }
    }
}
