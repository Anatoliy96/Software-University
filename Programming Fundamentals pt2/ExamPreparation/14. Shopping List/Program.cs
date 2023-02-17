using System;
using System.Collections.Generic;
using System.Linq;

namespace _14._Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> products = Console.ReadLine().Split("!", StringSplitOptions.RemoveEmptyEntries).ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "Go Shopping!" && command[1] != "Shopping!")
            {
                if (command[0] == "Urgent")
                {
                    string product = command[1];

                    if (!products.Contains(product))
                    {
                        products.Insert(0, product);
                    }
                }
                else if (command[0] == "Unnecessary")
                {
                    string product = command[1];

                    if (products.Contains(product))
                    {
                        products.Remove(product);
                    }
                }
                else if (command[0] == "Correct")
                {
                    string oldName = command[1];
                    string newName = command[2];

                    for (int i = 0; i < products.Count; i++)
                    {
                        if (products[i].Contains(oldName))
                        {
                            products[i] = newName;
                        }
                    }
                }
                else if (command[0] == "Rearrange")
                {
                    string product = command[1];

                    int index = products.FindIndex(p => p == product);

                    if (products.Contains(product))
                    {
                        products.RemoveAt(index);
                        products.Add(product);
                    }
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(String.Join(", ", products));
        }
    }
}
