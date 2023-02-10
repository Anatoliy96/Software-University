using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> l1 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> l2 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int min = Math.Min(l1.Count, l2.Count);

            for (int i = 0; i < min; i++)
            {
                Console.Write(l1[i] + " ");
                Console.Write(l2[i] + " ");
            }

            if (l1.Count > l2.Count)
            {
                for (int i = min; i < l1.Count; i++)
                {
                    Console.Write(l1[i] + " ");
                }
            }
            else if (l1.Count < l2.Count)
            {
                for (int i = min; i < l2.Count; i++)
                {
                    Console.Write(l2[i] + " ");
                }
            }
        }
    }
}
