using Handball.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Handball.Models
{
    public class Team : ITeam
    {
        private string name;
        private int pointsEarned;
        private List<IPlayer> players;
        
        public Team(string name)
        {
            Name = name;
            this.pointsEarned = 0;
            players = new List<IPlayer>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Team name cannot be null or empty.");
                }

                name = value;
            }
        }

        public int PointsEarned 
        { 
            get => pointsEarned; 
            set => pointsEarned = value; 
        }

        public double OverallRating => this.Players.Count == 0 ? 0 : Math.Round(this.players.Average(p => p.Rating), 2);


        public IReadOnlyCollection<IPlayer> Players { get => players.AsReadOnly(); }

        public void Draw()
        {
            pointsEarned += 1;

            this.Players.FirstOrDefault(p => p.GetType().Name == nameof(Goalkeeper)).IncreaseRating();
        }

        public void Lose()
        {
            foreach (var player in players)
            {
                player.DecreaseRating();
            }
        }

        public void SignContract(IPlayer player)
        {
           players.Add(player);
        }

        public void Win()
        {
            PointsEarned += 3;
            
            foreach (var player in players)
            {
                player.IncreaseRating();
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Team: {Name} Points: {PointsEarned}");
            sb.AppendLine($"--Overall rating: {OverallRating}");
            sb.Append($"--Players: ");

            if (this.Players.Any())
            {
                var names = this.Players.Select(p => p.Name);
                sb.Append(string.Join(", ", names));
            }
            else
            {
                sb.Append("none");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
