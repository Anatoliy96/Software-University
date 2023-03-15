using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            SortedDictionary<string, Dictionary<string, int>> users = new SortedDictionary<string, Dictionary<string,int>>();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end of contests")
            
            {
                string[] courses = command.Split(":");

                string course = courses[0];
                string password = courses[1];

                contests.Add(course, password);
            }

            while ((command = Console.ReadLine()) != "end of submissions")
            {
                string[] submissions = command.Split("=>");
                string course = submissions[0];
                string password = submissions[1];
                string username = submissions[2];
                int score = int.Parse(submissions[3]);


                if (users.ContainsKey(username) && users[username].ContainsKey(course))
                {
                    if (users[username][course] < score)
                    {
                        users[username][course] = score;
                    }
                }
                else if (users.ContainsKey(username))
                {
                    if (contests[course] == password)
                    {
                        users[username].Add(course, score);
                    }
                }
                else
                {
                    if (contests.ContainsKey(course))
                    {
                        if (contests[course] == password)
                        {
                            users.Add(username, new Dictionary<string, int>());
                            users[username].Add(course, score);
                        }
                    }
                }
            }

            string bestUser = string.Empty;
            int bestSumPoints = 0;

            foreach (var userName in users)
            {
                if (userName.Value.Values.Sum() > bestSumPoints)
                {
                    bestSumPoints = userName.Value.Values.Sum();
                    bestUser = userName.Key;
                }
            }

            Console.WriteLine($"Best candidate is {bestUser} with total {bestSumPoints} points.");
            Console.WriteLine("Ranking: ");


            foreach (var user in users)
            {
                Console.WriteLine(user.Key);
                Console.WriteLine(String.Join("\n", user.Value
                                              .OrderByDescending(x => x.Value)
                                              .Select(y => $"#  {y.Key} -> {y.Value}")));
            }
        } 
    }
}
