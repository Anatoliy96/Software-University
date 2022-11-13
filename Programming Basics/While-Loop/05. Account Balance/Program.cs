using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string money;
            double sum = 0;

            while ((money = Console.ReadLine()) != "NoMoreMoney")
            {
                double number = double.Parse(money);

                if (number < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase: {number:f2}");
                sum += number; 
            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
