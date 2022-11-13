using System;

namespace _08._Equal_Pairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pairOfNumbers = int.Parse(Console.ReadLine());

            int currentSum = 0;
            int sum = 0;
            int diffrence = 0;
            int maxDiffrence = 0;

            for (int i = 0; i < pairOfNumbers; i++)
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                currentSum = n1 + n2;

                if (i == 0)
                {
                    sum = currentSum;
                }
                else
                {
                    diffrence = Math.Abs(sum - currentSum);
                    sum = currentSum;
                }
                if (diffrence > maxDiffrence)
                {
                    maxDiffrence = diffrence;
                }
            }
            if (maxDiffrence == 0)
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else
            {

                Console.WriteLine($"No, maxdiff={maxDiffrence}");
            }
        }
    }
}
