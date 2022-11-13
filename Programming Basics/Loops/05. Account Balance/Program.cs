using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string transaction;

            decimal sum = 0;

            while ((transaction = Console.ReadLine()) != "NoMoreMoney")
            {
                decimal money = decimal.Parse(transaction);

                if (money <= 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {money:f2}");

                sum += money;

            }

            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
