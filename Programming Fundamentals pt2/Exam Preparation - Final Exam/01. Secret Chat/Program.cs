using System;
using System.Linq;

namespace _01._Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] command = Console.ReadLine().Split(":|:");

            while (command[0] != "Reveal")
            {
                if (command[0] == "InsertSpace")
                {
                    int index = int.Parse(command[1]);

                    input = input.Insert(index, " ");

                    Console.WriteLine(input);
                }
                else if (command[0] == "Reverse")
                {
                    string subString = command[1];

                    if (input.Contains(subString))
                    {
                        int index = input.IndexOf(subString);
                        string part = input.Substring(index, subString.Length);
                        input = input.Remove(index, part.Length);
                        char[] stringArray = part.ToCharArray();
                        Array.Reverse(stringArray);
                        string reversedStr = new string(stringArray);
                        input = input.Insert(input.Length, reversedStr);

                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command[0] == "ChangeAll")
                {
                    string subSubtring = command[1];
                    string replacement = command[2];

                    input = input.Replace(subSubtring, replacement);

                    Console.WriteLine(input);
                }

                command = Console.ReadLine().Split(":|:");
            }
            Console.WriteLine($"You have a new text message: {input}");
        }
    }
}
