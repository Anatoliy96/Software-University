using System;
using System.Collections.Generic;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();

            string companyName;

            while ((companyName = Console.ReadLine()) != "End")
            {
                string[] tokens = companyName.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                companyName = tokens[0];
                string id = tokens[1];


                if (!users.ContainsKey(companyName))
                {
                    users.Add(companyName, new List<string>());
                }

                if (users[companyName].Contains(id))

                {
                    continue;
                }
                else
                {
                    users[companyName].Add(id);
                }

            }

            foreach (var company in users)
            {
                string kvpCompany = company.Key;
                var id = company.Value;

                Console.WriteLine($"{kvpCompany}");

                foreach (var kvpId in id)
                {
                    Console.WriteLine($"-- {kvpId}");
                }
            }
        }
    }
}
