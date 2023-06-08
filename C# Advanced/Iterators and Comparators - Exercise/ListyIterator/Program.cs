namespace ListyIterator
{
    public class StarUp
    {
        public static void Main()
        {
            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            List<string> elemenets = new List<string>();

            for (int i = 1; i <= commands.Length - 1; i++)
            {
                elemenets.Add(commands[i]);
            }

            ListyIterator<string> listyInterator = new ListyIterator<string>();
            foreach (var item in elemenets)
            {
                listyInterator.Create(item);
            }

            commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (commands[0] != "END")
            {
                if (commands[0] == "Print")
                {
                    listyInterator.Print();
                }
                else if (commands[0] == "HasNext")
                {
                    bool result = listyInterator.HasNext();

                    Console.WriteLine(result);
                }
                else if (commands[0] == "Move")
                {
                    bool result = listyInterator.Move();

                    Console.WriteLine(result);
                }

                commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
