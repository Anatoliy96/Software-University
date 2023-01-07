using System;

namespace _01._The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Decode")
                {
                    break;
                }

                string[] tokens = command.Split('|');
                string action = tokens[0];

                if (action == "Move")
                {
                    int numberOfLetters = int.Parse(tokens[1]);
                    string stringToMove = message.Substring(0, numberOfLetters);

                    message = message.Remove(0, numberOfLetters);
                    message += stringToMove;
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(tokens[1]);
                    string value = tokens[2];

                    message = message.Insert(index, value);
                }
                else if (action == "ChangeAll")
                {
                    string subString = tokens[1];
                    string replacment = tokens[2];

                    message = message.Replace(subString, replacment);
                }
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
