using RobotService.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RobotService.Models
{
    public abstract class Robot : IRobot
    {
        private string model;
        private int batteryCapacity;
        private int convertionCapacityIndex;
        private List<int> interfaceStandards;

        public Robot(string model, int batteryCapacity, int convertionCapacityIndex)
        {
            this.Model = model;
            this.BatteryCapacity = batteryCapacity;
            this.ConvertionCapacityIndex = convertionCapacityIndex;

            this.BatteryLevel = this.BatteryCapacity;
            interfaceStandards = new List<int>();
        }

        public string Model
        {
            get => model;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Model cannot be null or empty.");
                }

                model = value;
            }
        }

        public int BatteryCapacity
        {
            get => batteryCapacity;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Battery capacity cannot drop below zero.");
                }

                batteryCapacity = value;
            }
        }

        public int BatteryLevel { get; set; }
       
        public int ConvertionCapacityIndex { get; set; }


        public IReadOnlyCollection<int> InterfaceStandards { get => interfaceStandards.AsReadOnly(); }

        public void Eating(int minutes)
        {
            int totalCapacity = this.ConvertionCapacityIndex * minutes;

            if (totalCapacity > this.BatteryCapacity - this.BatteryLevel) 
            {
                this.BatteryLevel = this.batteryCapacity;
            }
            else
            {
                this.batteryCapacity += totalCapacity;
            }
        }

        public bool ExecuteService(int consumedEnergy)
        {
            if (this.BatteryLevel >= consumedEnergy)
            {
                this.BatteryLevel -= consumedEnergy;
                return true;
            }

            return false;
        }

        public void InstallSupplement(ISupplement supplement)
        {
            interfaceStandards.Add(supplement.InterfaceStandard);

            this.batteryCapacity -= supplement.BatteryUsage;
            this.BatteryLevel -= supplement.BatteryUsage;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"{this.GetType().Name} {this.Model}:");
            sb.AppendLine($"--Maximum battery capacity: {this.BatteryCapacity}");
            sb.AppendLine($"--Current battery level: {this.BatteryLevel}");

            if (InterfaceStandards.Count == 0)
            {
                sb.AppendLine("--Supplements installed: none");
            }
            else
            {
                sb.AppendLine($"--Supplements installed: {string.Join(" ", interfaceStandards)}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
