using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> player1 = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> player2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sum = 0;

            while (true)
            {
                if (player1[0] > player2[0])
                {
                    player1.Add(player1[0]);
                    player1.Add(player2[0]);

                }
                else if (player1[0] < player2[0])
                {
                    player2.Add(player2[0]);
                    player2.Add(player1[0]);
                }

                player1.RemoveAt(0);
                player2.RemoveAt(0);

                if (player1.Count == 0)
                {
                    sum = player2.Sum();
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    break;
                }
                else if (player2.Count == 0)
                {
                    sum = player1.Sum();
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    break;
                }
            }
        }
    }
}
