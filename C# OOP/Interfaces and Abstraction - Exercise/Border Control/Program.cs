using BorderControl;

namespace BorderControl
{
    public class StartUp
    {
        public static void Main()
        {
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            List<IIdentity> identities = new List<IIdentity>();
            

            while (command[0] != "End")
            {
                if (command.Length == 3)
                {
                    string name = command[0];
                    int age = int.Parse(command[1]);
                    string id = command[2];

                    Citizen citizen = new Citizen(name, age, id);

                    identities.Add(citizen);
                }
                else if (command.Length == 2) 
                {
                    string model = command[0];
                    string id = command[1];

                    Robot robot = new Robot(model, id);

                    identities.Add(robot);
                }

                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            string fakeId = Console.ReadLine();

            foreach (var identity in identities)
            {
                string lastDigits = identity.Id.Substring(identity.Id.Length - fakeId.Length);

                if (lastDigits.Equals(fakeId, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{identity.Id}");
                }
            }
        }
    }
}
