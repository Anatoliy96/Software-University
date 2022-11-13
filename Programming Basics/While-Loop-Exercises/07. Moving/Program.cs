using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            string command;

            int cubicMetres = 0;
            int availableSpace = 0;
            availableSpace = width * lenght * height;

            while ((command = Console.ReadLine()) != "Done" || availableSpace <= 0)
            {
                int numberOfBoxes = int.Parse(command);

                cubicMetres += numberOfBoxes;

                if (availableSpace < cubicMetres)
                {
                    availableSpace -= cubicMetres;
                    Console.WriteLine($"No more free space! You need {Math.Abs(availableSpace)} Cubic meters more.");
                    break;
                }
            }

            if (command == "Done")
            {
                availableSpace -= cubicMetres;
                Console.WriteLine($"{availableSpace} Cubic meters left.");
            }
        }
    }
}
