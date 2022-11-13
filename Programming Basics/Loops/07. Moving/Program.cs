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

            int emptySpace = width * lenght * height;
            int occupiedSpace = 0;

            while ((command = Console.ReadLine()) != "Done")
            {
                int boxes = int.Parse(command);

                occupiedSpace += boxes;

                if (emptySpace < occupiedSpace)
                {
                    emptySpace -= occupiedSpace;
                    Console.WriteLine($"No more free space! You need {Math.Abs(emptySpace)} Cubic meters more.");
                    return;
                }
            }
            emptySpace -= occupiedSpace;
            Console.WriteLine($"{emptySpace} Cubic meters left.");
        }
    }
}
