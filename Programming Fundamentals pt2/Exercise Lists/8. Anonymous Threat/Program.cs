using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = Console.ReadLine();

            string result = "";
            while (command != "3:1")
            {
                string[] tokens = command.Split();

                if (tokens[0] == "merge")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);

                    if (endIndex < 0 || endIndex > input.Count - 1)
                    {
                        endIndex = input.Count - 1;
                    }
                    if (startIndex < 0 || startIndex > input.Count - 1)
                    {
                        startIndex = 0;
                    }

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        result += input[i];
                    }

                    input.RemoveRange(startIndex, endIndex - startIndex + 1);
                    input.Insert(startIndex, result);
                }

                else if (tokens[0] == "divide")
                {

                }

                command = Console.ReadLine();
            }
        }
    }
}
