using HighwayToPeak.Core.Contracts;
using HighwayToPeak.Models;
using HighwayToPeak.Models.Contracts;
using HighwayToPeak.Repositories;
using HighwayToPeak.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighwayToPeak.Core
{
    public class Controller : IController
    {
        private IRepository<IPeak> peaks;
        private IRepository<IClimber> climbers;
        private BaseCamp baseCamp;

        public Controller()
        {
            peaks = new PeakRepository();
            climbers = new ClimberRepository();
            baseCamp = new BaseCamp();
        }

        public string AddPeak(string name, int elevation, string difficultyLevel)
        {
            IPeak peak = peaks.Get(name);

            if (peak != null)
            {
                return $"{name} is already added as a valid mountain destination.";
            }

            if (difficultyLevel != "Moderate" && difficultyLevel != "Hard" && difficultyLevel != "Extreme")
            {
                return $"{difficultyLevel} peaks are not allowed for international climbers.";
            }

            peak = new Peak(name, elevation, difficultyLevel);

            peaks.Add(peak);

            return $"{name} is allowed for international climbing. See details in {typeof(PeakRepository).Name}.";
        }

        public string AttackPeak(string climberName, string peakName)
        {
            IClimber climber = climbers.Get(climberName);

            if (climber == null)
            {
                return $"Climber - {climberName}, has not arrived at the BaseCamp yet.";
            }

            IPeak peak = peaks.Get(peakName);

            if (peak == null)
            {
                return $"{peakName} is not allowed for international climbing.";
            }

            if (!baseCamp.Residents.Contains(climber.Name))
            {
                return $"{climberName} not found for gearing and instructions. The attack of {peakName} will be postponed.";
            }

            if (peak.DifficultyLevel == "Extreme" && climber.GetType().Name == typeof(NaturalClimber).Name)
            {
                return $"{climberName} does not cover the requirements for climbing {peakName}.";
            }

            baseCamp.LeaveCamp(climberName);
            climber.Climb(peak);

            if (climber.Stamina <= 0)
            {
                return $"{climberName} did not return to BaseCamp.";
            }
            else
            {
                baseCamp.ArriveAtCamp(climberName);

                return $"{climberName} successfully conquered {peakName} and returned to BaseCamp.";
            }
        }

        public string BaseCampReport()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("BaseCamp residents:");

            var residents = baseCamp.Residents.OrderBy(resident => climbers.Get(resident)?.Stamina ?? 0);

            if (baseCamp.Residents.Any())
            {
                foreach (var climberName in residents)
                {
                    var climber = climbers.Get(climberName);

                    sb.AppendLine($"Name: {climber.Name}, Stamina: {climber.Stamina}, Count of Conquered Peaks: {climber.ConqueredPeaks.Count}");
                }
            }
            else
            {
                sb.AppendLine("BaseCamp is currently empty.");
            }

            return sb.ToString().TrimEnd();
        }

        public string CampRecovery(string climberName, int daysToRecover)
        {
            IClimber climber = climbers.Get(climberName);

            if (!baseCamp.Residents.Contains(climberName))
            {
                return $"{climberName} not found at the BaseCamp.";
            }

            if (climber.Stamina == 10)
            {
                return $"{climberName} has no need of recovery.";
            }

            climber.Rest(daysToRecover);

            return $"{climberName} has been recovering for {daysToRecover} days and is ready to attack the mountain.";
        }

        public string NewClimberAtCamp(string name, bool isOxygenUsed)
        {
            IClimber climber = climbers.Get(name);

            if (climber != null)
            {
                return $"{name} is a participant in {typeof(ClimberRepository).Name} and cannot be duplicated.";
            }

            if (isOxygenUsed)
            {
                climber = new OxygenClimber(name);
            }
            else
            {
                climber = new NaturalClimber(name);
            }

            climbers.Add(climber);
            baseCamp.ArriveAtCamp(name);

            return $"{name} has arrived at the BaseCamp and will wait for the best conditions.";
        }

        public string OverallStatistics()
        {
            StringBuilder sb = new StringBuilder();

            var filteredClimbers = climbers.All
                .OrderByDescending(climber => climber.ConqueredPeaks.Count)
                .ThenBy(climber => climber.Name)
                .ToList();

            sb.AppendLine("***Highway-To-Peak***");

            foreach (var Climber in filteredClimbers)
            {
                sb.AppendLine(Climber.ToString());

                var filteredConquredPeaks = peaks.All.OrderByDescending(p => p.Elevation);

                foreach (var peak in filteredConquredPeaks)
                {
                    if (Climber.ConqueredPeaks.Contains(peak.Name))
                    {
                        sb.AppendLine(peak.ToString());
                    }
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
