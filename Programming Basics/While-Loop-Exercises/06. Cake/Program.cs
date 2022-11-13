using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            string command;
            int numberOfPeaces = 0;

            numberOfPeaces = lenght * width;

            while ((command = Console.ReadLine()) != "STOP")
            {
                int taking = int.Parse(command);

                numberOfPeaces -= taking;
                
                if (numberOfPeaces <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(numberOfPeaces)} pieces more.");
                    break;
                }
            }
            if (command == "STOP")
            {
                Console.WriteLine($"{numberOfPeaces} pieces are left.");
            }
        }
    }
}
