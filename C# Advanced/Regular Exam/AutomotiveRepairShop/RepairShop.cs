using System.Text;

namespace AutomotiveRepairShop
{
    public class RepairShop
    {
        public RepairShop(int capacity)
        {
            Capacity = capacity;
            Vehicles = new List<Vehicle>();
        }

        public int Capacity { get; set; }
        public List<Vehicle> Vehicles  { get; set; }

        public void AddVehicle(Vehicle vehicle)
        {
            if (Vehicles.Count < Capacity)
            {
                Vehicles.Add(vehicle);
            }
        }

        public bool RemoveVehicle(string vin)
        {
            Vehicle vehicleToRemove = Vehicles.FirstOrDefault(v => v.VIN == vin);

            if (vehicleToRemove == null)
            {
                return false;
            }

            Vehicles.Remove(vehicleToRemove);
            return true;
        }

        public int GetCount()
        {
            return Vehicles.Count;
        }
        public Vehicle GetLowestMileage()
        {
            Vehicle lowestMileAge = Vehicles[0];

            foreach (Vehicle vehicle in Vehicles)
            {
                if (vehicle.Mileage < lowestMileAge.Mileage)
                {
                    lowestMileAge = vehicle;
                }
            }

            return lowestMileAge;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Vehicles in the preparatory:");
            foreach (Vehicle vehicle in Vehicles)
            {
                sb.AppendLine($"{vehicle}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
