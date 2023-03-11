using System;

namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            foreach (var item in input)
            {
                char firstLetter = item[0];
                char lastLetter = item[item.Length - 1];

                double number = double.Parse(item.Substring(1, item.Length - 2));

                double result = 0;

                if (firstLetter >= 65 && firstLetter <= 90)
                {
                    int firstLetterPosition = firstLetter - 64;
                    result = number / firstLetterPosition;
                }
                else
                {
                    int firstLetterPosition = firstLetter - 96;
                    result = number * firstLetterPosition;
                }

                if (lastLetter >= 65 && lastLetter <= 90)
                {
                    int lastLetterPosition = lastLetter - 64;
                    sum += result - lastLetterPosition;
                }
                else
                {
                    int lastLetterPosition = lastLetter - 96;
                    sum += result + lastLetterPosition;
                }
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
