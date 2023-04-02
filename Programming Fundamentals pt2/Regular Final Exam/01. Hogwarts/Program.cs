using System;

namespace _01._Hogwarts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] command = Console.ReadLine().Split(' ');

            while (command[0] != "Abracadabra")
            {
                if (command[0] == "Abjuration")
                {
                    input = input.ToUpper();

                    Console.WriteLine(input);
                }
                else if (command[0] == "Necromancy")
                {
                    input = input.ToLower();

                    Console.WriteLine(input);
                }
                else if (command[0] == "Illusion") 
                {
                    int index = int.Parse(command[1]);
                    char letter = char.Parse(command[2]);

                    if (index >= 0 && index < input.Length)
                    {
                        char[] chars = input.ToCharArray();
                        chars[index] = letter;
                        input = new string(chars);

                        Console.WriteLine("Done!");
                    }
                    else
                    {
                        Console.WriteLine("The spell was too weak.");
                    }
                }
                else if (command[0] == "Divination")
                {
                    string firstSubstring = command[1];
                    string secondSubstring = command[2];

                    if (input.Contains(firstSubstring))
                    {
                        input = input.Replace(firstSubstring, secondSubstring);

                        Console.WriteLine(input);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command[0] == "Alteration")
                {
                    string subString = command[1];

                    if (input.Contains(subString))
                    {
                        input = input.Replace(subString, "");

                        Console.WriteLine(input);
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("The spell did not work!");
                }
                command = Console.ReadLine().Split(' ');
            }
        }
    }
}
