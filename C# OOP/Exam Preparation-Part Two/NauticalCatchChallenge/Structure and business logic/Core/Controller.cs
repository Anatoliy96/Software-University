using NauticalCatchChallenge.Core.Contracts;
using NauticalCatchChallenge.Models;
using NauticalCatchChallenge.Models.Contracts;
using NauticalCatchChallenge.Repositories;
using NauticalCatchChallenge.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NauticalCatchChallenge.Core
{
    public class Controller : IController
    {
        private IRepository<IDiver> divers;
        private IRepository<IFish> fishes;

        public Controller()
        {
            divers = new DiverRepository();
            fishes = new FishRepository();
        }

        public string ChaseFish(string diverName, string fishName, bool isLucky)
        {
            IDiver diver = divers.GetModel(diverName);

            if (diver == null)
            {
                return $"{typeof(DiverRepository).Name} has no {diverName} registered for the competition.";
            }

            IFish fish = fishes.GetModel(fishName);

            if (fish == null)
            {
                return $"{fishName} is not allowed to be caught in this competition.";
            }

            if (diver.HasHealthIssues)
            {
                return $"{diverName} will not be allowed to dive, due to health issues.";
            }

            if (diver.OxygenLevel < fish.TimeToCatch)
            {
                diver.Miss(fish.TimeToCatch);

                if (diver.OxygenLevel <= 0)
                {
                    diver.UpdateHealthStatus();
                }

                return $"{diverName} missed a good {fishName}.";
            }

            else if (diver.OxygenLevel == fish.TimeToCatch && !isLucky)
            {
                diver.Miss(fish.TimeToCatch);

                if (diver.OxygenLevel <= 0)
                {
                    diver.UpdateHealthStatus();
                }

                return $"{diverName} missed a good {fishName}.";
            }
            else
            {
                diver.Hit(fish);

                return $"{diverName} hits a {fish.Points}pt. {fishName}.";
            }
        }

        public string CompetitionStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("**Nautical-Catch-Challenge**");

            foreach (var diver in divers.Models
                .OrderByDescending(d => d.CompetitionPoints)
                .ThenByDescending(d => d.Catch.Count)
                .ThenBy(d => d.Name)
                .Where(d => d.HasHealthIssues == false))
            {
                sb.AppendLine(diver.ToString());
            }

            return sb.ToString().TrimEnd();
        }

        public string DiveIntoCompetition(string diverType, string diverName)
        {
            if (diverType != typeof(FreeDiver).Name && diverType != typeof(ScubaDiver).Name)
            {
                return $"{diverType} is not allowed in our competition.";
            }

            IDiver diver = divers.GetModel(diverName);

            if (diver != null) 
            {
                return $"{diverName} is already a participant -> {typeof(DiverRepository).Name}.";
            }

            if (diverType == typeof(FreeDiver).Name)
            {
                diver = new FreeDiver(diverName);
            }
            else if (diverType == typeof(ScubaDiver).Name)
            {
                diver = new ScubaDiver(diverName);
            }

            divers.AddModel(diver);

            return $"{diverName} is successfully registered for the competition -> {typeof(DiverRepository).Name}.";
        }

        public string DiverCatchReport(string diverName)
        {
            StringBuilder sb = new StringBuilder();

            var diver = divers.GetModel(diverName);

            sb.AppendLine(diver.ToString());

            sb.AppendLine("Catch Report:");

            foreach (var fisheName in diver.Catch)
            {
                IFish fish = fishes.GetModel(fisheName);

                sb.AppendLine(fish.ToString());
            }

            return sb.ToString().TrimEnd();
        }

        public string HealthRecovery()
        {
            var filteredDivers = divers.Models.Where(d => d.HasHealthIssues == true).ToList();

            foreach (IDiver diver in filteredDivers)
            {
                diver.UpdateHealthStatus();
                diver.RenewOxy();
            }

            return $"Divers recovered: {filteredDivers.Count}";
        }

        public string SwimIntoCompetition(string fishType, string fishName, double points)
        {
            if (fishType != typeof(ReefFish).Name && fishType != typeof(DeepSeaFish).Name && fishType != typeof(PredatoryFish).Name)
            {
                return $"{fishType} is forbidden for chasing in our competition.";
            }

            IFish fish = fishes.GetModel(fishName);

            if (fish != null)
            {
                return $"{fishName} is already allowed -> {typeof(FishRepository).Name}.";
            }

            if (fishType == typeof(ReefFish).Name)
            {
                fish = new ReefFish(fishName, points);
            }
            else if (fishType == typeof(DeepSeaFish).Name)
            {
                fish = new DeepSeaFish(fishName, points);
            }
            else if (fishType == typeof(PredatoryFish).Name)
            {
                fish = new PredatoryFish(fishName, points);
            }

            fishes.AddModel(fish);

            return $"{fishName} is allowed for chasing.";
        }
    }
}
