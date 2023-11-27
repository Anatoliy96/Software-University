using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCompetition.Models;
using UniversityCompetition.Models.Contracts;

namespace UniversityCompetition.Repositories.Contracts
{
    public class SubjectRepository : IRepository<ISubject>
    {
        private List<ISubject> subjects = new List<ISubject>();

        public SubjectRepository()
        {
            subjects = new List<ISubject>();
        }

        public IReadOnlyCollection<ISubject> Models { get => subjects.AsReadOnly(); }

        public void AddModel(ISubject model)
        {
            subjects.Add(model);
        }

        public ISubject FindById(int id)
        {
            return subjects.FirstOrDefault(x => x.Id == id);
        }

        public ISubject FindByName(string name)
        {
            return subjects.FirstOrDefault(s => s.Name == name);
        }
    }
}
