using System;

namespace _13._Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] command = Console.ReadLine().Split(">>>");

            while (command[0] != "Generate")
            {
                if (command[0] == "Contains")
                {
                    string subString = command[1];

                    if (input.Contains(subString))
                    {
                        Console.WriteLine($"{input} contains {subString}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (command[0] == "Flip")
                {
                    if (command[1] == "Upper")
                    {
                        int startIndex = int.Parse(command[2]);
                        int endIndex = int.Parse(command[3]);

                        string toUpper = input.Substring(startIndex, endIndex - startIndex).ToUpper();
                        input = input.Remove(startIndex, endIndex - startIndex);
                        input = input.Insert(startIndex, toUpper);
                        

                        Console.WriteLine(input);
                    }
                    else if (command[1] == "Lower")
                    {
                        int startIndex = int.Parse(command[2]);
                        int endIndex = int.Parse(command[3]);

                        string toLower = input.Substring(startIndex, endIndex - startIndex).ToLower();
                        input = input.Remove(startIndex, endIndex - startIndex);
                        input = input.Insert(startIndex, toLower);

                        Console.WriteLine(input);
                    }
                }
                else if (command[0] == "Slice")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    input = input.Remove(startIndex, endIndex - startIndex);

                    Console.WriteLine(input);
                }

                command = Console.ReadLine().Split(">>>");
            }

            Console.WriteLine($"Your activation key is: {input}");
        }
    }
}
