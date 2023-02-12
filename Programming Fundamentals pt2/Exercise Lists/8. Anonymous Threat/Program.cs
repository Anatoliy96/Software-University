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

            while (true)
            {
                string[] commands = Console.ReadLine().Split();
                string command = commands[0];

                if (command == "3:1")
                {
                    break;
                }

                int startIndex = int.Parse(commands[1]);
                int endIndex = int.Parse(commands[2]);
                string result = "";

                if (endIndex > input.Count - 1 || endIndex < 0)
                {
                    endIndex = input.Count - 1;
                }
                if (startIndex < 0 || startIndex > input.Count - 1)
                {
                    startIndex = 0;
                }

                if (command == "merge")
                {
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        result += input[i];
                    }
                    input.RemoveRange(startIndex, endIndex - startIndex + 1);
                    input.Insert(startIndex, result);
                }
                else if (command == "divide")
                {
                    List<string> devidedList = new List<string>();
                    var partitions = int.Parse(commands[2]);
                    string word = input[startIndex];
                    input.RemoveAt(startIndex);
                    int parts = word.Length / partitions;

                    for (int i = 0; i < partitions; i++)
                    {
                        if (i == partitions - 1)
                        {
                            devidedList.Add(word.Substring(i * parts));
                        }
                        else
                        {
                            devidedList.Add(word.Substring(i * parts, parts));
                        }
                    }
                    input.InsertRange(startIndex, devidedList);
                }
            }

            Console.WriteLine(String.Join(" ", input));
        }
    }
}
