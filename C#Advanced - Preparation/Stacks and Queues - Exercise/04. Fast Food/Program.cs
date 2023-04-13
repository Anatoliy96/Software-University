using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> clients = new Queue<int>();

            int maxOrder = int.MinValue;

            foreach (var order in orders)
            {
                clients.Enqueue(order);
            }

            foreach (var order in clients)
            {
                if (order > maxOrder)
                {
                    maxOrder = order;
                }
            }
            Console.WriteLine(maxOrder);

            while (clients.Count > 0)
            {
                if (foodQuantity >= clients.Peek())
                {
                    foodQuantity -= clients.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", clients)}");
                    return;
                }
            }
            Console.WriteLine("Orders complete");
        }
    }
}
