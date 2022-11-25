using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int countOfEquals = 1;
            int max = 0;
            int element = 0;
            

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    countOfEquals++;
                }

                else
                {
                    countOfEquals = 1;
                }

                if (countOfEquals > max)
                {
                    max = countOfEquals;

                    element = arr[i];
                }
            }

            for (int j = 1; j <= max; j++)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
