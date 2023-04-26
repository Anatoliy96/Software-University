using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lenghts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            HashSet<int> nLenght = new HashSet<int>();
            HashSet<int> mLenght = new HashSet<int>();
            HashSet<int> duplicates = new HashSet<int>();

            int n = lenghts[0];
            int m = lenghts[1];

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                nLenght.Add(num);
            }

            for (int i = 0;i < m; i++)
            {
                int num = int.Parse(Console.ReadLine());

                mLenght.Add(num);
            }

            foreach (var num in nLenght)
            {
                foreach (var num2 in mLenght)
                {
                    if (num == num2)
                    {
                        duplicates.Add(num);
                    }
                }
            }

            Console.WriteLine(String.Join(" ", duplicates));
        }
    }
}
