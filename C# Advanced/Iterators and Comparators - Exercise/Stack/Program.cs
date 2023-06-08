namespace Stack
{
    public class StartUp 
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string[] splitted = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Stack<int> stack = new Stack<int>();

            for (int i = 1; i <= splitted.Length - 1; i++)
            {
                stack.Push(int.Parse(splitted[i]));
            }

            string[] commnad = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (commnad[0] != "END")
            {
                if (commnad[0] == "Push")
                {
                    int elemenet = int.Parse(commnad[1]);
                    stack.Push(elemenet);
                }
                else if (commnad[0] == "Pop")
                {
                    stack.Pop();
                }

                commnad = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}