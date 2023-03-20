using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> contests = new Dictionary<string, Dictionary<string, int>>();

            string[] command = Console.ReadLine().Split("-> ");

            while (command[0] != "no more time")
            {
                string username = command[0];
                string contest = command[1];
                int score = int.Parse(command[2]);

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, new Dictionary<string, int>());
                }
                if (!contests[contest].ContainsKey(username))
                {
                    contests[contest].Add(username, score);
                }
                else if (contests[contest][username] < score)
                {
                    contests[contest][username] = score;
                }
                
                command = Console.ReadLine().Split("-> ");
            }

            int count = 1;

            foreach (var kvp in contests)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count()} participants");

                var sortedMembers = kvp.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
                
                foreach (var member in sortedMembers)
                {
                    Console.WriteLine($"{count}. {member.Key}<::> {member.Value}");
                    count++;
                }
                count = 1;
            }

            var allContestants = contests.SelectMany(c => c.Value)
                                     .GroupBy(c => c.Key)
                                     .Select(g => new { Name = g.Key, Points = g.Sum(c => c.Value) })
                                     .OrderByDescending(c => c.Points)
                                     .ThenBy(c => c.Name);

            Console.WriteLine("Individual standings:");

            foreach (var members in allContestants)
            {
                Console.WriteLine($"{count}. {members.Name}-> {members.Points}");
                count++;
            }
        }
    }
}
