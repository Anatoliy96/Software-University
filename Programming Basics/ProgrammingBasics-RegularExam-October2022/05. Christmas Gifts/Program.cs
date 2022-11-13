using System;

namespace _05._Christmas_Gifts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;

            int countOfChildren = 0;
            int countOfAdults = 0;

            while ((command = Console.ReadLine()) != "Christmas")
            {
                int familyMembersYears = int.Parse(command);

                if (familyMembersYears <= 16)
                {
                    countOfChildren++;
                }
                else if (familyMembersYears > 16)
                {
                    countOfAdults++;
                }
            }

            Console.WriteLine($"Number of adults: {countOfAdults}");
            Console.WriteLine($"Number of kids: {countOfChildren}");
            int moneyForToys = countOfChildren * 5;
            int moneyForSweaters = countOfAdults * 15;
            Console.WriteLine($"Money for toys: {moneyForToys}");
            Console.WriteLine($"Money for sweaters: {moneyForSweaters}");
        }
    }
}
