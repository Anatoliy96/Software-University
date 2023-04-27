using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ExamResults
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> participants = new Dictionary<string, int>();
            Dictionary<string, int> submissionCounts = new Dictionary<string, int>();

            while (command[0] != "exam finished")
            {
                if (command.Length == 3)
                {
                    string name = command[0];
                    string submission = command[1];
                    int score = int.Parse(command[2]);

                    if (!participants.ContainsKey(name))
                    {
                        participants.Add(name, score);

                        if (!submissionCounts.ContainsKey(submission))
                        {
                            submissionCounts.Add(submission, 0);
                        }
                        submissionCounts[submission]++;
                    }
                    else
                    {
                        if (participants[name] < score)
                        {
                            participants[name] = score;
                        }
                        submissionCounts[submission]++;
                    }
                }
                else if (command.Length == 2)
                {
                    string name = command[0];
                    string banned = command[1];

                    if (participants.ContainsKey(name))
                    {
                        participants.Remove(name);
                    }
                }
                command = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine("Results:");

            foreach (var participant in participants.OrderByDescending(p => p.Value).ThenBy(p => p.Key))
            {
                Console.WriteLine($"{participant.Key} | {participant.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var submission in submissionCounts.OrderByDescending(s => s.Value).ThenBy(s => s.Key))
            {
                Console.WriteLine($"{submission.Key} - {submission.Value}");
            }
        }
    }
}
