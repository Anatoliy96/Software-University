using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] tokens = command.Split(" ");

                string action = tokens[0];
                int startIndex = int.Parse(tokens[1]);
                int endIndex = int.Parse(tokens[2]);

                if (endIndex > list.Count - 1 || endIndex < 0)
                {
                    endIndex = list.Count - 1;
                }

                if (startIndex > list.Count - 1 || startIndex < 0)
                {
                    startIndex = 0;
                }

                if (action == "merge")
                {
                    string concat = string.Empty;

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        concat += list[i];
                    }
                    list.RemoveRange(startIndex, endIndex - startIndex + 1);
                    list.Insert(startIndex, concat);
                }
                else if (action == "divide")
                {
                    List<string> divided = new List<string>();

                    int partiosions = int.Parse(tokens[2]);
                    string word = list[startIndex];
                    list.RemoveAt(startIndex);
                    int parts = word.Length / partiosions;

                    for (int i = 0; i < partiosions; i++)
                    {
                        if (i == partiosions - 1)
                        {
                            divided.Add(word.Substring(i * parts));
                        }
                        else
                        {
                            divided.Add(word.Substring(i * parts, parts));
                        }
                    }

                    list.InsertRange(startIndex, divided);
                }
            }
            Console.WriteLine(string.Join(" ", list));
            
        }
    }
}
