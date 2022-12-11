using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split();
                string action = tokens[0];

                if (action == "Delete")
                {
                    int element = int.Parse(tokens[1]);

                    list.RemoveAll(e => e == element);
                }
                else if (action == "Insert")
                {
                    int element = int.Parse(tokens[1]);
                    int position = int.Parse(tokens[2]);

                    list.Insert(position, element);
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
