using Handball.Models.Contracts;
using Handball.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handball.Repositories
{
    public class PlayerRepository : IRepository<IPlayer>
    {
        private readonly List<IPlayer> players;

        public PlayerRepository()
        {
            players = new List<IPlayer>();
        }

        public IReadOnlyCollection<IPlayer> Models { get => players.AsReadOnly(); }

        public void AddModel(IPlayer model)
        {
            players.Add(model);
        }

        public bool ExistsModel(string name)
        {
            var player = GetModel(name);

            if (player != null)
            {
                return true;
            }
            return false;
        }

        public IPlayer GetModel(string name)
        {
           return players.FirstOrDefault(x => x.Name == name);
        }

        public bool RemoveModel(string name)
        {
            var playerToRemove = GetModel(name);

            if (playerToRemove != null)
            {
                players.Remove(playerToRemove);
                return true;
            }

            return false;
        }
    }
}
