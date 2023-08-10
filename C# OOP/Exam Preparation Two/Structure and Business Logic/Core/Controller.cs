using RobotService.Core.Contracts;
using RobotService.Models;
using RobotService.Models.Contracts;
using RobotService.Repositories;
using RobotService.Repositories.Contracts;
using RobotService.Utilities.Messages;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotService.Core
{
    public class Controller : IController
    {
        private IRepository<ISupplement> supplements;
        private IRepository<IRobot> robots;

        public Controller()
        {
            supplements = new SupplementRepository();
            robots = new RobotRepository();
        }

        public string CreateRobot(string model, string typeName)
        {
            if (typeName != "DomesticAssistant" && typeName != "IndustrialAssistant")
            {
                return $"Robot type {typeName} cannot be created.";
            }

            if (typeName == nameof(DomesticAssistant))
            {

                robots.AddNew(new DomesticAssistant(model));
            }

            else if (typeName == nameof(IndustrialAssistant))
            {
                robots.AddNew(new IndustrialAssistant(model));
            }

            return $"{typeName} {model} is created and added to the RobotRepository.";
        }

        public string CreateSupplement(string typeName)
        {
            if (typeName != nameof(SpecializedArm) && typeName != nameof(LaserRadar))
            {
                return $"{typeName} is not compatible with our robots.";
            }

            if (typeName == nameof(SpecializedArm))
            {
                supplements.AddNew(new SpecializedArm());
            }

            else if (typeName == nameof(LaserRadar))
            {
                supplements.AddNew(new LaserRadar());
            }

            return $"{typeName} is created and added to the SupplementRepository.";
        }

        public string PerformService(string serviceName, int intefaceStandard, int totalPowerNeeded)
        {
            IEnumerable<IRobot> filteredRobots = robots
            .Models()
            .Where(r => r.InterfaceStandards.Contains(intefaceStandard))
            .OrderByDescending(r => r.BatteryLevel);

            if (!filteredRobots.Any())
            {
                return string.Format(OutputMessages.UnableToPerform, intefaceStandard);
            }

            int availablePower = filteredRobots.Sum(r => r.BatteryLevel);

            if (availablePower < totalPowerNeeded)
            {
                return string.Format(OutputMessages.MorePowerNeeded, serviceName, totalPowerNeeded - availablePower);
            }

            int robotsCounter = 0;

            foreach (IRobot robot in filteredRobots)
            {
                robotsCounter++;

                if (robot.BatteryLevel >= totalPowerNeeded)
                {
                    robot.ExecuteService(totalPowerNeeded);

                    break;
                }

                totalPowerNeeded -= robot.BatteryLevel;
                robot.ExecuteService(robot.BatteryLevel);
            }

            return string.Format(OutputMessages.PerformedSuccessfully, serviceName, robotsCounter);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var robot in robots.Models().OrderByDescending(r => r.BatteryLevel).ThenBy(r => r.BatteryCapacity))
            {
                sb.AppendLine(robot.ToString());
            }

            return sb.ToString().TrimEnd();
        }

        public string RobotRecovery(string model, int minutes)
        {
            IEnumerable<IRobot> filteredRobots = robots
           .Models()
           .Where(r => r.Model == model && r.BatteryCapacity / 2 > r.BatteryLevel);

            int robotsCount = 0;

            foreach (IRobot robot in filteredRobots)
            {
                robotsCount++;
                robot.Eating(minutes);
            }

            return string.Format(OutputMessages.RobotsFed, robotsCount);
        }

        public string UpgradeRobot(string model, string supplementTypeName)
        {
            ISupplement supplement = supplements
            .Models()
            .FirstOrDefault(s => s.GetType().Name == supplementTypeName);

            IRobot robot = robots
                .Models()
                .FirstOrDefault(r => r.Model == model && !r.InterfaceStandards.Contains(supplement.InterfaceStandard));

            if (robot is null)
            {
                return string.Format(OutputMessages.AllModelsUpgraded, model);
            }

            robot.InstallSupplement(supplement);
            supplements.RemoveByName(supplementTypeName);

            return string.Format(OutputMessages.UpgradeSuccessful, model, supplementTypeName);
        }
    }
}
