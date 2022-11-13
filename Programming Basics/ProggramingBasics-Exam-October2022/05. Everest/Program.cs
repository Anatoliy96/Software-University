using System;

namespace _05._Everest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            int count = 1;
            int start = 5364;
            bool isSucceed = false;
            

            while ((command = Console.ReadLine()) != "END")
            {
                if (command == "Yes")
                {
                    count++;
                }

                if (start >= 8848)
                {
                    isSucceed = true;
                    break;
                }

                else if (count > 5)
                {
                    isSucceed = false;
                    break;
                }

                int meters = int.Parse(Console.ReadLine());

                start += meters;
            }

            if (isSucceed)
            {
                Console.WriteLine($"Goal reached for {count} days!");
            }
            else
            {
                Console.WriteLine("Failed!");
                Console.WriteLine($"{start}");
            }
        }
    }
}
