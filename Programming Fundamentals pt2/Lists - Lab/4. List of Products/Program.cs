using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();

                products.Add(product);
            }

            for (int i = 0; i < products.Count; i++)
            {
                Console.Write($"{i + 1}.{string.Join(" ", products[i])}");

                Console.WriteLine();
            }
        }
    }
}
