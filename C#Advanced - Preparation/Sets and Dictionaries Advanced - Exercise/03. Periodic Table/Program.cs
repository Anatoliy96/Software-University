using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> periodicTable = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] chemicals = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (chemicals.Length == 1)
                {
                    string chemical = chemicals[0];

                    periodicTable.Add(chemical);
                }
                else if (chemicals.Length == 2)
                {
                    string chemical1 = chemicals[0];
                    string chemical2 = chemicals[1];

                    periodicTable.Add(chemical1);
                    periodicTable.Add(chemical2);
                }
                else if (chemicals.Length == 3)
                {
                    string chemical1 = chemicals[0];
                    string chemical2 = chemicals[1];
                    string chemical3 = chemicals[2];

                    periodicTable.Add(chemical1);
                    periodicTable.Add(chemical2);
                    periodicTable.Add(chemical3);
                }
                else if (chemicals.Length == 4)
                {
                    string chemical1 = chemicals[0];
                    string chemical2 = chemicals[1];
                    string chemical3 = chemicals[2];
                    string chemical4 = chemicals[3];

                    periodicTable.Add(chemical1);
                    periodicTable.Add(chemical2);
                    periodicTable.Add(chemical3);
                    periodicTable.Add(chemical4);
                }
            }

            periodicTable = periodicTable.OrderBy(p => p).ToHashSet();
            Console.WriteLine(string.Join(" ", periodicTable));
        }
    }
}
