namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            List<List<int>> tiresYear = new List<List<int>>();
            List<List<double>> tiresPressure = new List<List<double>>();
            List<int> hoursePower = new List<int>();
            List<double> cubicCapacity = new List<double>();
            List<Car> cars = new List<Car>();

            string input = Console.ReadLine();

            Tire tires = new Tire();
            Engine engine = new Engine();
            
            while (input != "No more tires")
            {
                string[] splitted = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                List<int> year = tires.TiresYearInfo(splitted);
                List<double> pressures = tires.TiresPressureInfo(splitted);

                tiresYear.Add(year);
                tiresPressure.Add(pressures);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Engines done")
            {
                string[] splitted = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                hoursePower.Add(engine.GetHoursePower(splitted));
                cubicCapacity.Add(engine.GetCubicCapacity(splitted));

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Show special")
            {
                string[] splitted = input.Split();
                string make = splitted[0];
                string model = splitted[1];
                int year = int.Parse(splitted[2]);
                double fuelQuantity = double.Parse(splitted[3]);
                double fuelConsumption = double.Parse(splitted[4]);
                int engineIndex = int.Parse(splitted[5]);
                int tiresIndex = int.Parse(splitted[6]);

                int horsePower = hoursePower[engineIndex];
                double pressure = tires.GetSumPressure(tiresPressure, tiresIndex);

                Car car = new Car(make, model, year, horsePower, fuelQuantity, fuelConsumption,
                    engineIndex, tiresIndex, pressure);

                cars.Add(car);

                input = Console.ReadLine();
            }

            foreach(var car in cars)
            {
                if (car.Year >= 2017 && car.HorsePower > 330
                    && car.TotalPressure > 9 && car.TotalPressure < 10)
                {
                    car.FuelQuantity = car.Drive20Kilometers(car.FuelQuantity, car.FuelConsumption);

                    Console.WriteLine($"Make: {car.Make}");

                    Console.WriteLine($"Model: {car.Model}");

                    Console.WriteLine($"Year: {car.Year}");

                    Console.WriteLine($"HorsePowers: {car.HorsePower}");

                    Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
                }
            }
        }
    }
}
