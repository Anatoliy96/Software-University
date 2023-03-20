using System;
using System.Collections.Generic;

namespace _04._Snowwhite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> dwarfs = new Dictionary<string, Dictionary<string,int>>();

            string[] command = Console.ReadLine().Split("<:>");

            while (command[0] != "Once upon a time")
            {
                string name = command[0];
                string color = command[1];
                int psysics = int.Parse(command[2]);

                if (!dwarfs.ContainsKey(name))
                {
                    dwarfs.Add(name, new Dictionary<string, int>());

                    dwarfs[name].Add(color, psysics);
                }
                else if (dwarfs.ContainsKey(name) && !dwarfs[name].ContainsKey(color))
                {
                    dwarfs.Add(name, new Dictionary<string, int>());

                    dwarfs[name].Add(color, psysics);
                }
                else if (dwarfs.ContainsKey(name) && dwarfs[name].ContainsKey(color))
                {
                    if (dwarfs[name][color] < psysics)
                    {
                        dwarfs[name][color] = psysics;
                    }
                }
                command = Console.ReadLine().Split("<:>");
            }
        }
    }
}
