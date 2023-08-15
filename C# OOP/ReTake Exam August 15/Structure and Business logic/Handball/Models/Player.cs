using Handball.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handball.Models
{
    public abstract class Player : IPlayer
    {
        private string name;
        private double rating;

        public Player(string name, double rating)
        {
            this.Name = name;
            this.Rating = rating;
        }

        public string Name
        {
            get => name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Player name cannot be null or empty.");
                }
                name = value;
            }
        }

        public double Rating 
        {
            get => rating; 
            protected set => rating = value; 
        }

        public string Team { get; private set; }

        public abstract void DecreaseRating();
        
        public abstract void IncreaseRating();
        
        public void JoinTeam(string name)
        {
            this.Team = name;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.GetType().Name}: {Name}");
            sb.AppendLine($"--Rating: {this.Rating}");

            return sb.ToString().TrimEnd();
        }
    }
}
