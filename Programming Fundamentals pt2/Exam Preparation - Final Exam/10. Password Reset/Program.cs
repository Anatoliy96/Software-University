using System;

namespace _10._Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] command = Console.ReadLine().Split(' ');
            string newPassword = string.Empty;

            while (command[0] != "Done")
            {
                if (command[0] == "TakeOdd")
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            newPassword += input[i];
                        }
                    }

                    input = input.Replace(input, newPassword);
                    Console.WriteLine(input);
                }
                else if (command[0] == "Cut")
                {
                    int index = int.Parse(command[1]);
                    int lenght = int.Parse(command[2]);

                    input = input.Remove(index, lenght);

                    Console.WriteLine(input);
                }
                else if (command[0] == "Substitute")
                {
                    string subString = command[1];
                    string substituee = command[2];

                    if (input.Contains(subString))
                    {
                        input = input.Replace(subString, substituee);
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
                command = Console.ReadLine().Split(' ');
            }

            Console.WriteLine($"Your password is: {input}");
        }
    }
}
