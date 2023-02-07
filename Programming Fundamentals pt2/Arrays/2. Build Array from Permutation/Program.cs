using System;
using System.Linq;

namespace _2._Build_Array_from_Permutation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] result = Permutation(numbers);

            Console.WriteLine($"[{string.Join(", ", result)}]");
        }

        static int[] Permutation(int[] numbers)
        {
            int[] result = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = numbers[numbers[i]];
            }

            return result;
        }
    }
}
