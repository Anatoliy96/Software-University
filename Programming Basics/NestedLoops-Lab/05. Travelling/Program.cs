using System;

namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination;
            double sum = 0;

            while ((destination = Console.ReadLine()) != "End")
            {
                double budget = double.Parse(Console.ReadLine());

                for (int i = 0; i < budget; i++)
                {
                    double money = double.Parse(Console.ReadLine());

                    sum += money;

                    if (sum >= budget)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        sum = 0;
                        break;
                    }
                }
            }
        }
    }
}
