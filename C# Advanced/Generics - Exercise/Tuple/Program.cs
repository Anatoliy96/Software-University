namespace Tuple
{
    public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string firstName = input[0];
            string lastName = input[1];
            string address = input[2];

            Tuples<string, string> tuple1 = new Tuples<string, string>(firstName, lastName);

            Console.WriteLine($"{tuple1.Item1} {tuple1.Item2} -> {address}");

            input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string name = input[0];
            int litersOfBeer = int.Parse(input[1]);

            Tuples<string, int> tuple2 = new Tuples<string, int>(name, litersOfBeer);

            Console.WriteLine($"{tuple2.Item1} -> {tuple2.Item2}");

            input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int integer = int.Parse(input[0]);
            double doubles = double.Parse(input[1]);

            Tuples<int, double> tuple3 = new Tuples<int, double>(integer, doubles);

            Console.WriteLine($"{tuple3.Item1} -> {tuple3.Item2}");
        }
    }
}
