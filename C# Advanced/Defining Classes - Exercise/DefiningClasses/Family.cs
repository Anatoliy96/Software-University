using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> members;

        public Family()
        {
            members = new List<Person>();
        }

        public void AddMember(Person member)
        {
            members.Add(member);
        }

        public Person GetOldestMember()
        {
            Person oldest = members[0];

            foreach (Person member in members)
            {
                if (member.Age > oldest.Age)
                {
                    oldest = member;
                }
            }

            return oldest;
        }
    }
}
