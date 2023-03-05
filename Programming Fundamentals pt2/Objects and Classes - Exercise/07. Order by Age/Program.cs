using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var people = new Dictionary<string, (string Name, int Age)>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                string id = tokens[1];
                int age = int.Parse(tokens[2]);

                if (!people.ContainsKey(id))
                {
                    people.Add(id, (name, age));
                }
                else
                {
                    people[id] = (name, age);
                }
            }

            foreach (var person in people.OrderBy(p => p.Value.Age))
            {
                Console.WriteLine($"{person.Value.Name} with ID: {person.Key} is {person.Value.Age} years old.");
            }
        }

        public class Person
        {
            public Person(string firstName, int id, int age)
            {
                this.FirstName = firstName;
                this.Id = id;
                this.Age = age;
            }

            public string FirstName { get; set; }
            public int Id { get; set; }
            public int Age { get; set; }
        }
    }
}
