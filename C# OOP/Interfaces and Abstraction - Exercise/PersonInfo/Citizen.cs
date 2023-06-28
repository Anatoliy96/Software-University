using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfo
{
    public class Citizen : IPerson
    {
        private string name;
        private int age;

        public Citizen(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            private set { this.age = value; }
        }
    }
}
