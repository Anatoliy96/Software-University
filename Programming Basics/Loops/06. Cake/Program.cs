using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            string command;

            int numberOfPieces = width * lenght;

            while ((command = Console.ReadLine()) != "STOP")
            {
                int pieces = int.Parse(command);

                numberOfPieces -= pieces;

                if (numberOfPieces <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(numberOfPieces)} pieces more.");
                    return;
                }
            }
            Console.WriteLine($"{numberOfPieces} pieces are left.");
        }
    }
}
