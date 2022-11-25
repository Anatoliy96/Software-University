using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr =
                Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }

                leftSum = 0;

                for (int sumLeft = i; sumLeft > 0; sumLeft--)
                {
                    int nextLeftElementPosition = sumLeft - 1;

                    if (sumLeft > 0)
                    {
                        leftSum += arr[nextLeftElementPosition];
                    }
                }

                rightSum = 0;

                for (int sumRight = i; sumRight < arr.Length; sumRight++)
                {
                    int nextElementPosition = sumRight + 1;

                    if (sumRight < arr.Length - 1)
                    {
                        rightSum += arr[nextElementPosition];
                    }
                }

                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
