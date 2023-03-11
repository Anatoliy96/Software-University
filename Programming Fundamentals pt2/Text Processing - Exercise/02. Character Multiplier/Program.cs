using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            string first = input[0];
            string second = input[1];

            int sum = 0;
            int min = Math.Min(first.Length, second.Length);

            for (int i = 0; i < min; i++)
            {
                sum += first[i] * second[i];
            }

            if (first.Length > second.Length)
            {
                for (int i = min; i < first.Length; i++)
                {
                    sum += first[i];
                }
            }
            else
            {
                for (int i = min; i < second.Length; i++)
                {
                    sum += second[i];
                }

            }
            Console.WriteLine(sum);
        }
    }
}
