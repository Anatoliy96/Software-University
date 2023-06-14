using System;
using System.Collections.Generic;
using System.Linq;

namespace Basketball
{
    public class Team
    {
        public Team(string name, int openPositions, char group)
        {
            Name = name;
            OpenPositions = openPositions;
            Group = group;
            Players = new List<Player>();
        }
        public string Name { get; set; }
        public int OpenPositions { get; set; }
        public char Group { get; set; }
        public List<Player> Players { get; set; }
        public int Count { get { return Players.Count; } }

        public string AddPlayer(Player player)
        {
            if (string.IsNullOrEmpty(player.Name) || string.IsNullOrEmpty(player.Position))
            {
                return "Invalid player's information.";
            }
            if (OpenPositions == 0)
            {
                return "There are no more open positions.";
            }
            if (player.Rating < 80)
            {
                return "Invalid player's rating.";
            }
            else
            {
                Players.Add(player);
                OpenPositions--;
                return $"Successfully added {player.Name} to the team. Remaining open positions: {OpenPositions}.";
            }
        }

        public bool RemovePlayer(string name)
        {
            Player playerToRemove = Players.Find(x => x.Name == name);

            if (playerToRemove != null)
            {
                Players.Remove(playerToRemove);
                OpenPositions++;
                return true;
            }
            return false;
        }

        public int RemovePlayerByPosition(string position)
        {
            List<Player> playersToRemove = Players.FindAll(x => x.Position == position);
            int count = 0;
            if (playersToRemove.Count > 0)
            {
                foreach (var player in playersToRemove)
                {
                    Players.Remove(player);
                    count++;
                    OpenPositions--;
                }
                return count;
            }
            return 0;
        }

        public Player RetirePlayer(string name)
        {
            Player playerToFind = Players.FirstOrDefault(p => p.Name == name);

            if (playerToFind != null)
            {
                playerToFind.Retired = true;
                return playerToFind;
            }
            return null;
        }

        public List<Player> AwardPlayers(int games)
        {
            return Players.Where(player => player.Games >= games).ToList();
        }

        public string Report()
        {
            List<Player> activePlayers = Players.Where(player => !player.Retired).ToList();

            string result = $"Active players competing for Team {Name} from Group {Group}:";
            foreach (var player in activePlayers)
            {
                result += $"{Environment.NewLine}{player}";
            }
            return result;
        }
    }
}
