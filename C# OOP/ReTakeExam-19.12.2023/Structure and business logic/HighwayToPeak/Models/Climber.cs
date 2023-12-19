﻿using HighwayToPeak.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighwayToPeak.Models
{
    public abstract class Climber : IClimber
    {
        private string name;
        private int stamina;
        private List<string> conqueredPeaks;

        protected Climber(string name, int stamina)
        {
            Name = name;
            Stamina = stamina;

            conqueredPeaks = new List<string>();
        }

        public string Name
        {
            get => name; 
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Climber's name cannot be null or whitespace.");
                }
                name = value;
            }
        }

        public int Stamina
        {
            get => stamina; 
            protected set
            {
                if (value > 10)
                {
                    stamina = 10;
                }
                else if (value < 0)
                {
                    stamina = 0;
                }
                else
                {
                    stamina = value;
                }
            }
        }

        public IReadOnlyCollection<string> ConqueredPeaks => conqueredPeaks.AsReadOnly();

        public void Climb(IPeak peak)
        {
            if (!conqueredPeaks.Contains(peak.Name))
            {
                conqueredPeaks.Add(peak.Name);
            }

            if (peak.DifficultyLevel == "Moderate")
            {
                this.Stamina -= 2;
            }
            else if (peak.DifficultyLevel == "Hard")
            {
                this.Stamina -= 4;
            }
            else if (peak.DifficultyLevel == "Extreme")
            {
                this.Stamina -= 6;
            }
        }

        public abstract void Rest(int daysCount);

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.GetType().Name} - Name: {Name}, Stamina: {Stamina}");

            if (conqueredPeaks.Any())
            {
                sb.AppendLine($"Peaks conquered: {conqueredPeaks.Count}");
            }
            else
            {
                sb.AppendLine("Peaks conquered: no peaks conquered");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
