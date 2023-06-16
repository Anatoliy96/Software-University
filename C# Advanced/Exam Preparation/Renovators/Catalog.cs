using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        public Catalog(string name, int neededRenovators, string project)
        {
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
            Renovators = new List<Renovator>();
        }

        public string Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }
        public List<Renovator> Renovators { get; set; }
        public int Count { get { return Renovators.Count; } }

        public string AddRenovator(Renovator renovator)
        {
            if (string.IsNullOrEmpty(renovator.Name) || string.IsNullOrEmpty(renovator.Type))
            {
                return "Invalid renovator's information.";
            }
            if (NeededRenovators <= Renovators.Count)
            {
                return "Renovators are no more needed.";
            }
            if (renovator.Rate > 350)
            {
                return "Invalid renovator's rate.";
            }

            Renovators.Add(renovator);
            return $"Successfully added {renovator.Name} to the catalog.";
        }

        public bool RemoveRenovator(string name)
        {
            var renovatorToRemove = Renovators.Find(x => x.Name == name);

            if (renovatorToRemove == null)
            { 
                return false;
            }

            return true;
        }

        public int RemoveRenovatorBySpecialty(string type)
        {
            int count = 0;

            var renovatorsType = Renovators.FindAll(x => x.Type == type).ToList();

            foreach (var renovator in renovatorsType)
            {
                if (renovator != null)
                {
                    Renovators.Remove(renovator);
                    count++;
                }
            }

            return count;
        }

        public Renovator HireRenovator(string name)
        {
            Renovator renovator = Renovators.Where(r => r.Name == name).FirstOrDefault();

            if (renovator == null)
            {
                return null;
            }

            renovator.Hired = true;
            return renovator;
        }

        public List<Renovator> PayRenovators(int days)
        {
            List<Renovator> renovators = Renovators.Where(r => r.Days >= days).ToList();

            return renovators;
        }

        public string Report()
        {
            List<Renovator> freeRenovators = Renovators.FindAll(r => r.Hired == false);

            string result = $"Renovators available for Project {Project}:";

            foreach (var renovator in freeRenovators)
            {
                result += $"{Environment.NewLine}{renovator}";
            }

            return result;
        }
    }
}
