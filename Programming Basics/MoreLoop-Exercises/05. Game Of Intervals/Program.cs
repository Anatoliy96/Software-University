using System;

namespace _05._Game_Of_Intervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleInGame = int.Parse(Console.ReadLine());

            double result = 0;
            double countFromZeroToNine = 0;
            double countFromTenToNineTheen = 0;
            double countFromTwentyToTwentyNine = 0;
            double countFromThirteenToThirtyNine = 0;
            double countFromFourtheenToFiftheen = 0;
            double countOfInvalidNumbers = 0;

            for (int i = 0; i < peopleInGame; i++)
            {
                double numbers = double.Parse(Console.ReadLine());

                if (numbers >= 0 && numbers <= 9)
                {
                    numbers *= 0.20;
                    result += numbers;
                    countFromZeroToNine++;
                }
                else if (numbers >= 10 && numbers <= 19)
                {
                    numbers *= 0.30;
                    result += numbers;
                    countFromTenToNineTheen++;
                }
                else if (numbers >= 20 && numbers <= 29)
                {
                    numbers *= 0.40;
                    result += numbers;
                    countFromTwentyToTwentyNine++;
                }
                else if (numbers >= 30 && numbers <= 39)
                {
                    result += 50;
                    countFromThirteenToThirtyNine++;
                }
                else if (numbers >= 40 && numbers <= 50)
                {
                    result += 100;
                    countFromFourtheenToFiftheen++;
                }
                else if (numbers < 0 || numbers > 50)
                {
                    result /= 2;
                    countOfInvalidNumbers++;
                }
            }
            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {countFromZeroToNine * 100 / peopleInGame:f2}%");
            Console.WriteLine($"From 10 to 19: {countFromTenToNineTheen * 100 / peopleInGame:f2}%");
            Console.WriteLine($"From 20 to 29: {countFromTwentyToTwentyNine * 100 / peopleInGame:f2}%");
            Console.WriteLine($"From 30 to 39: {countFromThirteenToThirtyNine * 100 / peopleInGame:f2}%");
            Console.WriteLine($"From 40 to 50: {countFromFourtheenToFiftheen * 100 / peopleInGame:f2}%");
            Console.WriteLine($"Invalid numbers: {countOfInvalidNumbers * 100 / peopleInGame:f2}%");
        }
    }
}

