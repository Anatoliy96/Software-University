using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(' ');
            Dictionary<string, VLogger> vloggers = new Dictionary<string, VLogger>();

            while (command[0] != "Statistics")
            {
                if (command[1] == "joined")
                {
                    string vlogger = command[0];

                    if (!vloggers.ContainsKey(vlogger))
                    {
                        vloggers.Add(vlogger, new VLogger());
                        vloggers[vlogger].Followers = new List<string>();
                        vloggers[vlogger].Following = new List<string>();
                    }

                }
                else if (command[1] == "followed")
                {
                    string vlogger1 = command[0];
                    string vlogger2 = command[2];


                    if (vloggers.ContainsKey(vlogger1) && vloggers.ContainsKey(vlogger2))
                    {
                        if (vlogger1 != vlogger2 && !vloggers[vlogger1].Following.Contains(vlogger2))
                        {
                            vloggers[vlogger1].Following.Add(vlogger2);
                            vloggers[vlogger2].Followers.Add(vlogger1);
                        }
                    }
                }
                command = Console.ReadLine().Split(' ');
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            int count = 1;

            foreach (var vlogger in vloggers.OrderByDescending(v => v.Value.Followers.Count).ThenBy(v => v.Value.Following.Count))
            {
                Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value.Followers.Count} followers, {vlogger.Value.Following.Count} following");

                if (count == 1)
                {
                    foreach (string follower in vlogger.Value.Followers.OrderBy(f => f))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }

                count++;
            }

        }

        public class VLogger
        {
            public List<string> Followers { get; set; }
            public List<string> Following { get; set; }
        }
    }
}
