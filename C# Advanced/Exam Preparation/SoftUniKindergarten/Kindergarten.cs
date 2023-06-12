using System.Collections.Generic;
using System.Linq;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Registry = new List<Child>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Child> Registry { get; set; }

        public bool AddChild(Child child)
        {
            if (Registry.Count < Capacity)
            {
                Registry.Add(child);
                return true;
            }
            return false;
        }

        public bool RemoveChild(string childFullName)
        {
            Child child = Registry.FirstOrDefault(c => c.FirstName + " " + c.LastName == childFullName);

            if (child != null)
            {
                Registry.Remove(child);
                return true;
            }

            return false;
        }

        public int ChildrenCount()
        {
            return Registry.Count;
        }

        public Child GetChild(string childFullName)
        {
            Child child = Registry.FirstOrDefault(c => c.FirstName + " " + c.LastName == childFullName);

            if (child != null)
            {
                return child;
            }
            
            return null;
        }

        public string RegistryReport()
        {
            var orderedChildren = Registry.OrderByDescending(c => c.Age).ThenBy(c => c.LastName).ThenBy(c => c.FirstName).ToList();

            string report = $"Registered children in {Name}:\n";
            report += string.Join("\n", orderedChildren);
            return report;
        }
    }
}
