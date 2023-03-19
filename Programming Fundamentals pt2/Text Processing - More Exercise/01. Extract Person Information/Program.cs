using System;
using System.Text;

namespace _01._Extract_Person_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder name = new StringBuilder();
            StringBuilder age = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();

                int personNameStartIndex = text.IndexOf('@');
                int personNameEndIndex = text.IndexOf('|');   
                string personName = text.Substring(personNameStartIndex + 1, personNameEndIndex - personNameStartIndex - 1);

                name.Append(personName);

                int personAgeStartIndex = text.IndexOf('#');
                int personAgeEndIndex = text.IndexOf('*');
                string personAge = text.Substring(personAgeStartIndex + 1, personAgeEndIndex - personAgeStartIndex - 1);
                int ageOfPerson = int.Parse(personAge);
                age.Append(ageOfPerson);

                Console.WriteLine($"{name} is {age} years old.");

                name.Clear();
                age.Clear();
            }
        }
    }
}
