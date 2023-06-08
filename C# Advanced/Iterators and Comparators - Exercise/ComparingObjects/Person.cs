using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingObjects
{
    public class Person : IComparable<Person>
    {
        private List<Person> people;

        public Person()
        {
            people = new List<Person>();
        }
        public Person(string name, int age, string town) : this()
        {
            Name = name;
            Age = age;
            Town = town;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public int CompareTo(Person other)
        {
            int nameComparison = Name.CompareTo(other.Name);
            if (nameComparison != 0)
            {
                return nameComparison;
            }

            int ageComparison = Age.CompareTo(other.Age);
            if (ageComparison != 0)
            {
                return ageComparison;
            }
            
            return Town.CompareTo(other.Town);
        }

        public void Add(Person person)
        {
            people.Add(person);
        }
    }
}
