using System;

namespace _05._Challenge_the_Wedding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int men = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int numberOfTables = int.Parse(Console.ReadLine());

            int spaceCounter = 0;
            bool isEmpty = false;

            for (int i = 1; i <= men; i++)
            {
                for (int j = 1; j <= women; j++)
                {
                    spaceCounter++;

                    Console.Write($"({i} <-> {j}) ");

                    if (numberOfTables == spaceCounter)
                    {
                        isEmpty = true;
                        break;
                    }
                }
                if (isEmpty)
                {
                    break;
                }
            }
        }
    }
}
