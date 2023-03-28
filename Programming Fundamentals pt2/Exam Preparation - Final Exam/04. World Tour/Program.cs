using System;

namespace _04._World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] command = Console.ReadLine().Split(":");

            while (command[0] != "Travel")
            {
                if (command[0] == "Add Stop")
                {
                    int index = int.Parse(command[1]);
                    string text = command[2];

                    if (index >= 0 && index <= input.Length - 1)
                    {
                        input = input.Insert(index, text);
                    }
                    Console.WriteLine(input);
                }
                else if (command[0] == "Remove Stop")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    if (startIndex >= 0 && startIndex <= input.Length - 1 && endIndex >= 0 && endIndex <= input.Length - 1)
                    {
                        input = input.Remove(startIndex, endIndex - startIndex + 1);
                    }
                    Console.WriteLine(input);
                }
                else if (command[0] == "Switch")
                {
                    string oldText = command[1];
                    string newText = command[2];

                    if (input.Contains(oldText))
                    {
                        input = input.Replace(oldText, newText);
                    }
                    Console.WriteLine(input);
                }

                command = Console.ReadLine().Split(":");
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {string.Join("::", input)}");
        }
    }
}
