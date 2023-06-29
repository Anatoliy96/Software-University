using System.Globalization;

namespace BirthdayCelebrations
{
    public class StartUp
    {
        public static void Main()
        {
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            List<IBirthable> birthdates = new List<IBirthable>();

            while (command[0] != "End")
            {
                if (command[0] == "Citizen")
                {
                    string name = command[1];
                    int age = int.Parse(command[2]);
                    string id = command[3];
                    string birthdate = command[4];

                    Citizen citizen = new Citizen(name, age, id, birthdate);

                    birthdates.Add(citizen);
                }
                else if (command[0] == "Robot")
                {
                    string model = command[1];
                    string id = command[2];

                    Robot robot = new Robot(model, id);

                }
                else if (command[0] == "Pet")
                {
                    string name = command[1];
                    string birthdate = command[2];

                    Pet pet = new Pet(name, birthdate);

                    birthdates.Add(pet);
                }

                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            string year = Console.ReadLine();

            foreach (var date in birthdates)
            {
                if (date.Birthdate.EndsWith(year))
                {
                    Console.WriteLine(date.Birthdate);
                }
            }
        }
    }
}
