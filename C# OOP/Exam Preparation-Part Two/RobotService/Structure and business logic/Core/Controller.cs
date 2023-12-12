using RobotService.Core.Contracts;
using RobotService.Models;
using RobotService.Models.Contracts;
using RobotService.Repositories;
using RobotService.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RobotService.Core
{
    public class Controller : IController
    {
        private IRepository<IRobot> robots;
        private IRepository<ISupplement> supplements;

        public Controller()
        {
            robots = new RobotRepository();
            supplements = new SupplementRepository();
        }

        public string CreateRobot(string model, string typeName)
        {
            IRobot robot = null;

            if (typeName != typeof(DomesticAssistant).Name && typeName != typeof(IndustrialAssistant).Name)
            {
                return $"Robot type {typeName} cannot be created.";
            }

            if (typeName == typeof(DomesticAssistant).Name)
            {
                robot = new DomesticAssistant(model);
            }
            else if (typeName == typeof(IndustrialAssistant).Name)
            {
                robot = new IndustrialAssistant(model);
            }

            robots.AddNew(robot);

            return $"{typeName} {model} is created and added to the RobotRepository.";
        }

        public string CreateSupplement(string typeName)
        {
            ISupplement supplement = null;

            if (typeName != typeof(SpecializedArm).Name && typeName != typeof(LaserRadar).Name)
            {
                return $"{typeName} is not compatible with our robots.";
            }

            if (typeName == typeof(SpecializedArm).Name)
            {
                supplement = new SpecializedArm();
            }
            else if (typeName == typeof(LaserRadar).Name)
            {
                supplement = new LaserRadar();
            }
            supplements.AddNew(supplement);

            return $"{typeName} is created and added to the SupplementRepository.";
        }

        public string PerformService(string serviceName, int intefaceStandard, int totalPowerNeeded)
        {
            var filteredRobots = robots.Models()
                .Where(r => r.InterfaceStandards.Contains(intefaceStandard))
                .OrderByDescending(r => r.BatteryLevel)
                .ToList();

            if (!filteredRobots.Any())
            {
                return $"Unable to perform service, {intefaceStandard} not supported!";
            }

            int availablePower = filteredRobots.Sum(r => r.BatteryLevel);

            if (availablePower < totalPowerNeeded)
            {
                return $"{serviceName} cannot be executed! {totalPowerNeeded - availablePower} more power needed.";
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
                robot.ExecuteService(totalPowerNeeded);
            }

            return $"{serviceName} is performed successfully with {robotsCounter} robots.";
        }

        public string Report()
        {
            var filteredRobots = robots.Models().OrderByDescending(r => r.BatteryLevel)
                .ThenBy(r => r.BatteryCapacity)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var robot in filteredRobots)
            {
                sb.AppendLine(robot.ToString());
            }

            return sb.ToString().TrimEnd();
        }

        public string RobotRecovery(string model, int minutes)
        {
            var filteredRobots = robots.Models()
                .Where(r => r.Model == model && r.BatteryCapacity / 2 > r.BatteryLevel)
                .ToList();

            int fedRobotsCount = 0;

            foreach (IRobot robot in filteredRobots)
            {
                robot.Eating(minutes);

                fedRobotsCount++;
            }

            return $"Robots fed: {fedRobotsCount}";
        }

        public string UpgradeRobot(string model, string supplementTypeName)
        {
            ISupplement supplement = supplements.Models().FirstOrDefault(s => s.GetType().Name == supplementTypeName);

            IRobot robot = robots.Models().FirstOrDefault(r => r.Model == model && 
            !r.InterfaceStandards.Contains(supplement.InterfaceStandard));

            if (robot == null)
            {
                return $"All {model} are already upgraded!";
            }

            robot.InstallSupplement(supplement);
            supplements.RemoveByName(supplementTypeName);

            return $"{model} is upgraded with {supplementTypeName}.";
        }
    }
}
