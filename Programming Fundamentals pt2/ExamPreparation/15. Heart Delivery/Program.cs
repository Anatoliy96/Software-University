using System;
using System.Linq;

namespace _15._Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberOfHearts = Console.ReadLine().Split("@", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            
            string[] commnad = Console.ReadLine().Split();

            int currenyPosition = 0;

            while (commnad[0] != "Love!")
            {
                int jump = int.Parse(commnad[1]);

                currenyPosition += jump;

                if (currenyPosition > numberOfHearts.Length - 1)
                {
                    currenyPosition = 0;
                }
                if (numberOfHearts[currenyPosition] == 0)
                {
                    Console.WriteLine($"Place {currenyPosition} already had Valentine's day.");
                }
                else if (numberOfHearts[currenyPosition] > 0)
                {
                    numberOfHearts[currenyPosition] -= 2;

                    if (numberOfHearts[currenyPosition] == 0)
                    {
                        Console.WriteLine($"Place {currenyPosition} has Valentine's day.");
                    }
                }

                commnad = Console.ReadLine().Split();
            }

            Console.WriteLine($"Cupid's last position was {currenyPosition}.");

            int countOfHearts = 0;
            int countWithoutHearts = 0;

            for (int i = 0; i < numberOfHearts.Length; i++)
            {
                if (numberOfHearts[i] == 0)
                {
                    countOfHearts++;
                }
                else
                {
                    countWithoutHearts++;
                }
            }
            if (countOfHearts == numberOfHearts.Length)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {countWithoutHearts} places.");
            }
        }
    }
}
