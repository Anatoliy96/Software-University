using System;

namespace _06._Sum_And_Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int production = 0;

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 9; b >= a; b--)
                {
                    for (int c = 0; c <= 9; c++)
                    {
                        for (int d = 9; d >= c; d--)
                        {
                            sum = a + b + c + d;
                            production = a * b * c * d;

                            if (sum == production && n % 10 == 5)
                            {
                                Console.WriteLine($"{a}{b}{c}{d}");
                                return;
                            }
                            else if (production / sum == 3 && n % 3 == 0)
                            {
                                Console.WriteLine($"{d}{c}{b}{a}");
                                return;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Nothing found");
        }
    }
}
