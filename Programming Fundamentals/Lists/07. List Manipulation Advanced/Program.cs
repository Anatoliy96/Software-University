using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            bool isListChanged = false;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split();
                string action = tokens[0];

                switch (action)
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        numbers.Add(numberToAdd);
                        isListChanged = true;
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        numbers.Remove(numberToRemove);
                        isListChanged = true;
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(tokens[1]);
                        numbers.RemoveAt(indexToRemove);
                        isListChanged = true;
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        isListChanged = true;
                        break;

                    case "Contains":
                        int numberToCheck = int.Parse(tokens[1]);

                        if (numbers.Contains(numberToCheck))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;

                    case "PrintEven":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                Console.Write($"{numbers[i]} ");
                            }
                        }

                        Console.WriteLine();

                        break;

                    case "PrintOdd":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 != 0)
                            {
                                Console.Write($"{numbers[i]} ");
                            }
                        }
                        Console.WriteLine();

                        break;

                    case "GetSum":
                        int sum = 0;

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sum += numbers[i];
                        }
                        
                        Console.WriteLine(sum);
                        break;

                    case "Filter":
                        string condition = (tokens[1]);
                        int numberToFilter = int.Parse(tokens[2]);

                        switch (condition)
                        {
                            case "<":
                                foreach (var number in numbers)
                                {
                                    if (number < numberToFilter)
                                    {
                                        Console.Write($"{number} ");
                                    }
                                }
                                Console.WriteLine();
                                break;

                            case ">":
                                foreach (var number in numbers)
                                {
                                    if (number > numberToFilter)
                                    {
                                        Console.Write($"{number} ");
                                    }
                                }
                                Console.WriteLine();
                                break;

                                

                            case ">=":
                                foreach (var number in numbers)
                                {
                                    if (number >= numberToFilter)
                                    {
                                        Console.Write($"{number} ");
                                    }
                                }
                                Console.WriteLine();
                                break;

                            case "<=":
                                foreach (var number in numbers)
                                {
                                    if (number <= numberToFilter)
                                    {
                                        Console.Write($"{number} ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                        }

                        break;
                }
            }
            if (isListChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
