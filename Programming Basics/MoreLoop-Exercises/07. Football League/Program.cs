using System;

namespace _07._Football_League
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int numberOfFans = int.Parse(Console.ReadLine());

            double SectorAFans = 0;
            double SectorBFans = 0;
            double SectorVFans = 0;
            double SectorGFans = 0;

            for (int i = 0; i < numberOfFans; i++)
            {
                string sector = Console.ReadLine();

                if (sector == "A")
                {
                    SectorAFans++;
                }
                else if (sector == "B")
                {
                    SectorBFans++;
                }
                else if (sector == "V")
                {
                    SectorVFans++;
                }
                else if (sector == "G")
                {
                    SectorGFans++;
                }
            }

            Console.WriteLine($"{SectorAFans / numberOfFans * 100:f2}%");
            Console.WriteLine($"{SectorBFans / numberOfFans * 100:f2}%");
            Console.WriteLine($"{SectorVFans / numberOfFans * 100:f2}%");
            Console.WriteLine($"{SectorGFans / numberOfFans * 100:f2}%");
            Console.WriteLine($"{(double)numberOfFans / stadiumCapacity * 100:f2}%");
        }
    }
}
