namespace FoodShortage
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<IBuyer> buyers = new List<IBuyer>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command.Length == 4)
                {
                    string name = command[0];
                    int age = int.Parse(command[1]);
                    string id = command[2];
                    string birthdate = command[3];

                    Citizen citizen = new Citizen(name, age, id, birthdate);

                    buyers.Add(citizen);
                }
                else if (command.Length == 3)
                {
                    string name = command[0];
                    int age = int.Parse(command[1]);
                    string group = command[2];

                    Rebel rebel = new Rebel(name, age, group);

                    buyers.Add(rebel);
                }
            }

            string input = Console.ReadLine();

            while (input != "End") 
            {
                buyers.FirstOrDefault(buyer => buyer.Name == input)?.BuyFood();

                input = Console.ReadLine();
            }

            Console.WriteLine(buyers.Sum(b => b.Food));
        }
    }
}
