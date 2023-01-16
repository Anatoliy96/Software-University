using System;

namespace _03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OutFall 4 $39.99

            //CS: OG $15.99

            //Zplinter Zell $19.99

            //Honored 2 $59.99

            //RoverWatch $29.99

            //RoverWatch Origins Edition $39.99

            double money = double.Parse(Console.ReadLine());

            string command;

            double spent = 0;
            double remaining = 0;

            while ((command = Console.ReadLine()) != "Game Time")
            {
                if (command != "OutFall 4" && command != "CS: OG" && command != "Zplinter Zell" && command != "Honored 2" 
                    && command != "RoverWatch" && command != "RoverWatch Origins Edition")
                {
                    Console.WriteLine("Not Found");
                    continue;
                }

                

                if (command == "OutFall 4")
                {
                    if (money < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"Bought {command}");
                        money -= 39.99;
                        spent += 39.99;
                        remaining = money;
                    }
                }
                else if (command == "CS: OG")
                {
                    if (money < 15.99)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"Bought {command}");
                        money -= 15.99;
                        spent += 15.99;
                        remaining = money;
                    }
                    
                }
                else if (command == "Zplinter Zell")
                {
                    if (money < 19.99)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"Bought {command}");
                        money -= 19.99;
                        spent += 19.99;
                        remaining = money;
                    }
                }
                else if (command == "Honored 2")
                {
                    if (money < 59.99)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"Bought {command}");
                        money -= 59.99;
                        spent += 59.99;
                        remaining = money;
                    }
                }
                else if (command == "RoverWatch")
                {
                    if (money < 29.99)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"Bought {command}");
                        money -= 29.99;
                        spent += 29.99;
                        remaining = money;
                    }
                }
                else if (command == "RoverWatch Origins Edition")
                {
                    if (money < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"Bought {command}");
                        money -= 39.99;
                        spent += 39.99;
                        remaining = money;
                    }
                }
                if (money <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }

            Console.WriteLine($"Total spent: ${spent:f2}. Remaining: ${remaining:f2}");
        }
    }
}
