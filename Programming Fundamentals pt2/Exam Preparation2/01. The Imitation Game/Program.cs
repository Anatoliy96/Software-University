using System;

namespace _01._The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();
            string[] commands = Console.ReadLine().Split("|");
            string letters = string.Empty;
            
            while (commands[0] != "Decode")
            {
                if (commands[0] == "Move")
                {
                    int numberOfLetters = int.Parse(commands[1]);

                    letters = encryptedMessage.Substring(0, numberOfLetters);
                    encryptedMessage = encryptedMessage.Remove(0, numberOfLetters);
                    encryptedMessage = encryptedMessage.Insert(encryptedMessage.Length, letters);
                }
                else if (commands[0] == "Insert")
                {
                    int index = int.Parse(commands[1]);
                    string value = commands[2];

                    encryptedMessage = encryptedMessage.Insert(index, value);
                }
                else if (commands[0] == "ChangeAll")
                {
                    string subString = commands[1];
                    string replacement = commands[2];

                    foreach (var occurrence in encryptedMessage)
                    {
                        if (occurrence.ToString() == subString)
                        {
                            encryptedMessage = encryptedMessage.Replace(subString, replacement);
                        }
                    }
                }

                commands = Console.ReadLine().Split("|");
            }

            Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }
    }
}
