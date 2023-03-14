using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Contest> contests = new Dictionary<string, Contest>();
            Dictionary<string, User> users = new Dictionary<string, User>();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end of contests")
            {
                string[] courses = command.Split(":");

                string course = courses[0];
                string password = courses[1];

                contests.Add(course, new Contest
                {
                    Password = password,
                    Participants = new Dictionary<string, int>()
                });
            }

            while ((command = Console.ReadLine()) != "end of submissions")
            {
                string[] submissions = command.Split("=>");

                string course = submissions[0];
                string password = submissions[1];
                string username = submissions[2];
                int score = int.Parse(submissions[3]);

                if (contests.ContainsKey(course) && contests[course].Password == password)
                {
                    if (!users.ContainsKey(username))
                    {
                        users.Add(username, new User
                        {
                            Name = username,
                            PointsByContest = new Dictionary<string, int>()
                        });
                    }
                }
                if (!users[username].PointsByContest.ContainsKey(course))
                {
                    users[username].PointsByContest.Add(course, score);
                }
                else if (score > users[username].PointsByContest[course])
                {
                    users[username].PointsByContest[course] = score;
                }

                User bestCandidate = users.Values.OrderByDescending(u => u.TotalPoints).FirstOrDefault();
                Console.WriteLine($"Best candidate is {bestCandidate.Name} with total {bestCandidate.TotalPoints} points.");

                foreach (User user in users.Values.OrderBy(u => u.Name))
                {
                    Console.WriteLine(user.Name);
                    foreach (KeyValuePair<string, int> contestPoints in user.PointsByContest.OrderByDescending(cp => cp.Value))
                    {
                        Console.WriteLine($"# {contestPoints.Key} -> {contestPoints.Value}");
                    }
                }
            }
        }

        public class Contest
        {
            public string Password { get; set; }
            public Dictionary<string, int> Participants { get; set; }
        }
        public class User
        {
            public string Name { get; set; }
            public Dictionary<string, int> PointsByContest { get; set; }

            public int TotalPoints => PointsByContest.Values.Sum();
        }
    }
}
