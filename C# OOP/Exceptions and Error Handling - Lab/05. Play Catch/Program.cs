
int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

int countOfExeptions = 0;

while (countOfExeptions < 3)
{
    string[] currentInput = Console.ReadLine().Split();

	try
	{
        if (currentInput[0] == "Replace")
        {
            int firstIndex = int.Parse(currentInput[1]);
            int secondIndex = int.Parse(currentInput[2]);

            int temp = input[firstIndex];
            input[firstIndex] = input[secondIndex];
            input[secondIndex] = temp;
        }
        else if (currentInput[0] == "Show")
        {
            int firstIndex = int.Parse(currentInput[1]);

            Console.WriteLine(input[firstIndex]);
        }
        else if (currentInput[0] == "Print")
        {
            int firstIndex = int.Parse(currentInput[1]);
            int secondIndex = int.Parse(currentInput[2]);

            if (firstIndex < 0 || firstIndex > input.Length || secondIndex < 0 || secondIndex > input.Length)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(string.Join(", " , input));
            }
        }
    }
	catch (ArgumentException ex)
	{
        Console.WriteLine("The index does not exist!");
    }
    catch (FormatException ex)
    {
        Console.WriteLine("The variable is not in the correct format!");
    }
}
