using System;
using System.Linq;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(",").Select(int.Parse).ToArray();

            int target = int.Parse(Console.ReadLine());

            int[] indexes = twoSum(numbers, target);

            Console.WriteLine($"[{string.Join(",", indexes)}]");
        }

        public static int[] twoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return null;
        }
    }
}
