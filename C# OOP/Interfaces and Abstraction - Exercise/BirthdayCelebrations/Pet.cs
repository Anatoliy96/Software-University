using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations
{
    public class Pet : IBirthable
    {
        private string name;
        private string birthdate;

        public Pet(string name, string birthdate)
        {
            this.name = name;
            this.birthdate = birthdate;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Birthdate
        {
            get { return this.birthdate; }
            private set { this.birthdate = value; }
        }
    }
}
