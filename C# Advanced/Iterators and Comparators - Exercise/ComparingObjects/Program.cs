namespace ComparingObjects
{
    public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            List<Person> persons = new List<Person>();
            
            while (input[0] != "END")
            {
                string name = input[0];
                int age = int.Parse(input[1]);
                string town = input[2];

                Person person = new Person(name, age, town);

                persons.Add(person);

                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            int n = int.Parse(Console.ReadLine());

            Person targetPerson = persons[n - 1];

            int matchesCount = 0;
            int notEqualCount = 0;

            foreach (Person people in persons)
            {
                int comparisonResult = people.CompareTo(targetPerson);
                if (comparisonResult == 0)
                {
                    matchesCount++;
                }
                else
                {
                    notEqualCount++;
                }
            }

            int totalCount = persons.Count();

            if (matchesCount > 1)
            {
                Console.WriteLine($"{matchesCount} {notEqualCount} {totalCount}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
