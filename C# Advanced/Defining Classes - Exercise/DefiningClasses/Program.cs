using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            List<Car> cars = new();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] carProps = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car car = new(
                    carProps[0],
                    int.Parse(carProps[1]),
                    int.Parse(carProps[2]),
                    int.Parse(carProps[3]),
                    carProps[4],
                    double.Parse(carProps[5]),
                    int.Parse(carProps[6]),
                    double.Parse(carProps[7]),
                    int.Parse(carProps[8]),
                    double.Parse(carProps[9]),
                    int.Parse(carProps[10]),
                    double.Parse(carProps[11]),
                    int.Parse(carProps[12])
                    );

                cars.Add(car);
            }

            string command = Console.ReadLine();

            string[] filteredCarModels;

            if (command == "fragile")
            {
                filteredCarModels = cars
                    .Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1))
                    .Select(c => c.Model)
                    .ToArray();
            }
            else
            {
                filteredCarModels = cars
                    .Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250)
                    .Select(c => c.Model)
                    .ToArray();
            }

            Console.WriteLine(string.Join(Environment.NewLine, filteredCarModels));
        }
        //static Engine CreateEngine(string[] enginePropeties)
        //{
        //    Engine engine = new(enginePropeties[0], int.Parse(enginePropeties[1]));

        //    if (enginePropeties.Length > 2)
        //    {
        //        int displacement;

        //        bool isDigit = int.TryParse(enginePropeties[2], out displacement);

        //        if (isDigit)
        //        {
        //            engine.Displacement = displacement;
        //        }
        //        else
        //        {
        //            engine.Efficiency = enginePropeties[2];
        //        }

        //        if (enginePropeties.Length > 3)
        //        {
        //            engine.Efficiency = enginePropeties[3];
        //        }
        //    }

        //    return engine;
        //}
        //static Car CreateCar(string[] carPropeties, List<Engine> engines)
        //{
        //    Engine engine = engines.Find(x => x.Model == carPropeties[1]);

        //    Car car = new(carPropeties[0], engine);

        //    if (carPropeties.Length > 2)
        //    {
        //        int weight;

        //        bool isDigit = int.TryParse(carPropeties[2], out weight);

        //        if (isDigit)
        //        {
        //            car.Weight = weight;
        //        }
        //        else
        //        {
        //            car.Color = carPropeties[2];
        //        }

        //        if (carPropeties.Length > 3)
        //        {
        //            car.Color = carPropeties[3];
        //        }
        //    }

        //    return car;
        //}
    }
}
