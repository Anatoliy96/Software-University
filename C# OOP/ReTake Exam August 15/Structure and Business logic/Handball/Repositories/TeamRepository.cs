using Handball.Models;
using Handball.Models.Contracts;
using Handball.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handball.Repositories
{
    public class TeamRepository : IRepository<ITeam>
    {
        private readonly List<ITeam> teams;

        public TeamRepository()
        {
            teams = new List<ITeam>();
        }

        public IReadOnlyCollection<ITeam> Models { get => teams.AsReadOnly(); }

        public void AddModel(ITeam model)
        {
            teams.Add(model);
        }

        public bool ExistsModel(string name)
        {
            var team = GetModel(name);

            if (team != null)
            {
                return true;
            }
            return false;
        }

        public ITeam GetModel(string name)
        {
            return teams.FirstOrDefault(t => t.Name == name);
        }

        public bool RemoveModel(string name)
        {
            var teamToRemove = GetModel(name);

            if (teamToRemove != null)
            {
                teams.Remove(teamToRemove);
                return true;
            }

            return false;
        }
    }
}
