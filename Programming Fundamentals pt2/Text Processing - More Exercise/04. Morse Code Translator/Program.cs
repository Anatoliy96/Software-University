using System;

namespace _04._Morse_Code_Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] tokens = input.Split(' ');
            string result = string.Empty;

            for (int i = 0; i < tokens.Length; i++)
            {
                if (tokens[i] == "|")
                {
                    result += "|";
                }
                else if (tokens[i] == ".-")
                {
                    result += "A";
                }
                else if (tokens[i] == "-...")
                {
                    result += "B";
                }
                else if (tokens[i] == "-.-.")
                {
                    result += "C";
                }
                else if (tokens[i] == "-..")
                {
                    result += "D";
                }
                else if (tokens[i] == ".")
                {
                    result += "E";
                }
                else if (tokens[i] == "..-.")
                {
                    result += "F";
                }
                else if (tokens[i] == "--.")
                {
                    result += "G";
                }
                else if (tokens[i] == "....")
                {
                    result += "H";
                }
                else if (tokens[i] == "..")
                {
                    result += "I";
                }
                else if (tokens[i] == ".---")
                {
                    result += "J";
                }
                else if (tokens[i] == "-.-")
                {
                    result += "K";
                }
                else if (tokens[i] == ".-..")
                {
                    result += "L";
                }
                else if (tokens[i] == "--")
                {
                    result += "M";
                }
                else if (tokens[i] == "-.")
                {
                    result += "N";
                }
                else if (tokens[i] == "---")
                {
                    result += "O";
                }
                else if (tokens[i] == ".--.")
                {
                    result += "P";
                }
                else if (tokens[i] == "--.-")
                {
                    result = "Q";
                }
                else if (tokens[i] == ".-.")
                {
                    result += "R";
                }
                else if (tokens[i] == "...")
                {
                    result += "S";
                }
                else if (tokens[i] == "-")
                {
                    result += "T";
                }
                else if (tokens[i] == "..-")
                {
                    result += "U";
                }
                else if (tokens[i] == "...-")
                {
                    result += "V";
                }
                else if (tokens[i] == ".--")
                {
                    result += "W";
                }
                else if (tokens[i] == "-..-")
                {
                    result += "X";
                }
                else if (tokens[i] == "-.--")
                {
                    result += "Y";
                }
                else if (tokens[i] == "--..")
                {
                    result += "Z";
                }
            }
            string message = result.Replace("|", " ");
            Console.WriteLine(message);
        }
    }
}
