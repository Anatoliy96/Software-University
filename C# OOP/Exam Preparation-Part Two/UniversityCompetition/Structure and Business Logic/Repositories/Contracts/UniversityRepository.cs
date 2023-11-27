using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCompetition.Models.Contracts;

namespace UniversityCompetition.Repositories.Contracts
{
    public class UniversityRepository : IRepository<IUniversity>
    {
        private List<IUniversity> universities;

        public UniversityRepository()
        {
            universities = new List<IUniversity>();
        }

        public IReadOnlyCollection<IUniversity> Models { get => universities.AsReadOnly(); }

        public void AddModel(IUniversity model)
        {
            universities.Add(model);
        }

        public IUniversity FindById(int id)
        {
            return universities.FirstOrDefault(x => x.Id == id);
        }

        public IUniversity FindByName(string name)
        {
            return universities.FirstOrDefault(x => x.Name == name);
        }
    }
}
