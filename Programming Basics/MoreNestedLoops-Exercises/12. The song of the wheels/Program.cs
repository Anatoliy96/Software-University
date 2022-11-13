using System;

namespace _12._The_song_of_the_wheels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int controlValue = int.Parse(Console.ReadLine());
            int counter = 0;

            int firstNum = 0;
            int secondNum = 0;
            int thirdNum = 0;
            int fourthNum = 0;

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 0; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (a * b + c * d == controlValue && a < b && c > d)
                            {
                                counter++;
                                Console.Write($"{a}{b}{c}{d} ");

                                if (counter == 4)
                                {
                                    firstNum = a;
                                    secondNum = b;
                                    thirdNum = c;
                                    fourthNum = d;
                                }
                                else if (counter == 0)
                                {
                                    Console.WriteLine("No!");
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            if (counter < 4)
            {
                Console.WriteLine();
                Console.WriteLine("No!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Password: {firstNum}{secondNum}{thirdNum}{fourthNum}");
            }
        }
    }
}
