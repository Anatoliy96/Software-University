﻿using Handball.Models.Contracts;
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
        private List<IPlayer> players;

        public PlayerRepository()
        {
            players = new List<IPlayer>();
        }

        public IReadOnlyCollection<IPlayer> Models => players.AsReadOnly();

        public void AddModel(IPlayer model)
        {
            players.Add(model);
        }

        public bool ExistsModel(string name)
        {
            IPlayer playerToFind = players.FirstOrDefault(p => p.Name == name);

            if (playerToFind != null)
            {
                return true;
            }

            return false;
        }

        public IPlayer GetModel(string name)
        {
            return players.FirstOrDefault(p => p.Name == name);
        }

        public bool RemoveModel(string name)
        {
            IPlayer playerToRemove = players.FirstOrDefault(p => p.Name == name);

            if (playerToRemove != null)
            {
                players.Remove(playerToRemove);

                return true;
            }

            return false;
        }
    }
}
