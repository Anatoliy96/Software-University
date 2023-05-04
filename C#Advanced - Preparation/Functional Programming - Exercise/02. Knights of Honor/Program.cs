using System;
using System.Linq;

namespace _02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ');

            Action<string> action = (a) => Console.WriteLine("Sir" + " " + a);

            names.ToList().ForEach(a => action(a));
        }
    }
}
