namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                double tire1Pressure = double.Parse(input[5]);
                int tire1Age = int.Parse(input[6]);
                double tire2Pressure = double.Parse(input[7]);
                int tire2Age = int.Parse(input[8]);
                double tire3Pressure = double.Parse(input[9]);
                int tire3Age = int.Parse(input[10]);
                double tire4Pressure = double.Parse(input[11]);
                int tire4Age = int.Parse(input[12]);

                var tires = new Tires[4]
                {
                    new Tires(tire1Pressure, tire1Age),
                    new Tires(tire2Pressure, tire2Age),
                    new Tires(tire3Pressure, tire3Age),
                    new Tires(tire4Pressure, tire4Age),
                };

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, cargoWeight);
                Car car = new Car(model, engine, cargo, tires);

                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in cars)
                {
                    foreach (var tire in car.Tires)
                    {
                        if (car.Cargo.Type == command && tire.Pressure < 1)
                        {
                            Console.WriteLine($"{car.Model}");
                            return;
                        }
                    }
                }
            }
            else if (command == "flammable")
            {
                foreach (var car in cars)
                {
                    if (car.Cargo.Type == command && car.Engine.Power > 250)
                    {
                        Console.WriteLine($"{car.Model}");
                    }
                }
            }
        }
    }
}
