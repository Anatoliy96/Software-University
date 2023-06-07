namespace Threeuple
{
    public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string firstName = input[0];
            string lastName = input[1];
            string address = input[2];
           
            Tuple<string, string, string> tuple1 = new Tuple<string, string, string>(firstName, lastName, address);

            Console.WriteLine($"{tuple1.Item1} {tuple1.Item2} -> {tuple1.Item3} -> {string.Join(" ", input[3..])}");

            input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string name = input[0];
            int litersOfBeer = int.Parse(input[1]);
            string drunkOrNot = input[2];

            bool isDrunk = false;

            Tuple<string, int, bool> tuple2 = new Tuple<string, int, bool>(name, litersOfBeer, isDrunk);

            if (drunkOrNot == "drunk")
            {
                isDrunk = true;
                tuple2 = new Tuple<string, int, bool>(name, litersOfBeer, isDrunk);
                Console.WriteLine($"{tuple2.Item1} -> {tuple2.Item2} -> {tuple2.Item3}");
            }
            else
            {
                Console.WriteLine($"{tuple2.Item1} -> {tuple2.Item2} -> {tuple2.Item3}");
            }

            input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string name2 = input[0];
            double accountBalance = double.Parse(input[1]);
            string bankName = input[2];

            Tuple<string, double, string> tuple3 = new Tuple<string, double, string>(name2, accountBalance, bankName);

            Console.WriteLine($"{tuple3.Item1} -> {tuple3.Item2} -> {tuple3.Item3}");
        }
    }
}