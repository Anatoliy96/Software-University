using System;

namespace _02._AND_Processors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCPU = int.Parse(Console.ReadLine());
            int numberOfEmployees = int.Parse(Console.ReadLine());
            int workingDays = int.Parse(Console.ReadLine());

            int hours = numberOfEmployees * workingDays * 8;
            double produce = hours / 3; 
            Math.Floor(produce);

            if (produce < numberOfCPU)
            {
                double cpuLess = numberOfCPU - produce;
                double loses = cpuLess * 110.10;
                Console.WriteLine($"Losses: -> {loses:f2} BGN");
            }
            else
            {
                double cpuMore = produce - numberOfCPU;
                double profit = cpuMore * 110.10;
                Console.WriteLine($"Profit: -> {profit:f2} BGN");
            }
        }
    }
}
