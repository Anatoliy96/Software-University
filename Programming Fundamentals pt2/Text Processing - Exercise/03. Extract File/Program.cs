using System;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("\\");

            string file = input[input.Length - 1];
            string[] splitWords = file.Split(".");
            string fileName = splitWords[0];
            string extention = splitWords[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extention}");
        }
    }
}
