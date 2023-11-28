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
        private List<ISubject> subjects;

        public SubjectRepository()
        {
            subjects = new List<ISubject>();
        }

        public IReadOnlyCollection<ISubject> Models { get => subjects.AsReadOnly(); }

        public void AddModel(ISubject model)
        {
            ISubject subject = null;

            if (model is TechnicalSubject)
            {
                subject = new TechnicalSubject(Models.Count + 1, model.Name);
            }
            else if (model is HumanitySubject)
            {
                subject = new HumanitySubject(Models.Count + 1, model.Name);
            }
            else if (model is EconomicalSubject)
            {
                subject = new EconomicalSubject(Models.Count + 1, model.Name);
            }

            subjects.Add(subject);
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
