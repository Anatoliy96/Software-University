using System;

namespace _06._Wedding_Seats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char sector = char.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            int oddRows = int.Parse(Console.ReadLine());

            int counter = 0;

            for (char i = 'A'; i <= sector; i++)
            {
                if (i != 'A')
                {
                    rows++;
                }

                for (int j = 1; j <= rows; j++)
                {
                    if (j % 2 == 0)
                    {
                        for (char k = 'a'; k < 'a' + j + oddRows; k++)
                        {
                            Console.WriteLine($"{i}{j}{k}");
                            counter++;
                        }
                    }
                    else
                    {
                        for (char k = 'a'; k < 'a' + oddRows; k++)
                        {
                            Console.WriteLine($"{i}{j}{k}");
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
