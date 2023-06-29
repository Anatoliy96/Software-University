using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations
{
    public class Citizen : IIdentity, IBirthable
    {
        private string name;
        private int age;
        private string id;
        private string birthdate;

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.name = name;
            this.age = age;
            this.Id = id;
            this.birthdate = birthdate;
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

        public string Id
        {
            get { return this.id; }
            private set { this.id = value; }
        }

        public string Birthdate
        {
            get { return this.birthdate; }
            private set { this.birthdate = value;}
        }
    }
}
