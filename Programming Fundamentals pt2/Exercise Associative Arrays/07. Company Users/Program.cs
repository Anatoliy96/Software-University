using System;
using System.Collections.Generic;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            while (command[0] != "End")
            {
                string companyName = command[0];
                string id = command[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());

                }
                if (!companies[companyName].Contains(id))
                {
                    companies[companyName].Add(id);
                }
                command = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var kvp in companies)
            {
                Console.WriteLine($"{kvp.Key}");

                foreach (var id in kvp.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
