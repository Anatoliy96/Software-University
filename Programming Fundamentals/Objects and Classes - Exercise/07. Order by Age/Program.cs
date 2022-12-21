using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;

            List<Person> persons = new List<Person>();

            while ((command = Console.ReadLine()) != "End")
            {
                string[] elements = command.Split(' ');
                string firstName = elements[0];
                string id = elements[1];
                int age = int.Parse(elements[2]);
                Person person = new Person(firstName, id, age);

                foreach (var p in persons)
                {
                    if (p.Id == id)
                    {
                        person.Edit(firstName, age);
                    }
                }

                persons.Add(person);
            }

            var sortedPersons = persons.OrderBy(p => p.Age).ToList();

            foreach (var person in sortedPersons)
            {
                Console.WriteLine(person);
            }
        }
    }

    public class Person
    {
        public Person(string firstName, string id, int age)
        {
            this.FirstName = firstName;
            this.Id = id;
            this.Age = age;
        }

        public string FirstName { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public void Edit(string firstName, int age)
        {
            FirstName = firstName;
            Age = age;
        }

        public override string ToString()
        {
            return $"{FirstName} with ID: {Id} is {Age} years old.";
        }
    }
}
