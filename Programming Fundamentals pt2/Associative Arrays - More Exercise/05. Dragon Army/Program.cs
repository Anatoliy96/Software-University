using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Dragon_Army
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, SortedDictionary<string, Dragon>> dragons = new Dictionary<string, SortedDictionary<string, Dragon>>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ');

                string type = command[0];
                string name = command[1];
                string damage = command[2];
                string health = command[3];
                string armor = command[4];

                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new SortedDictionary<string, Dragon>());
                }


                if (dragons[type].ContainsKey(name))
                {
                    if (damage != "null")
                    {
                        dragons[type][name].Damage = double.Parse(damage);
                    }
                    else
                    {
                        dragons[type][name].Damage = 45;
                    }
                    if (health != "null")
                    {
                        dragons[type][name].Health = double.Parse(health);
                    }
                    else
                    {
                        dragons[type][name].Health = 250;
                    }
                    if (armor != "null")
                    {
                        dragons[type][name].Armor = double.Parse(armor);
                    }
                    else
                    {
                        dragons[type][name].Armor = 10;
                    }
                }
                else
                {
                    dragons[type].Add(name, new Dragon());

                    if (damage != "null")
                    {
                        dragons[type][name].Damage = double.Parse(damage);
                    }
                    if (health != "null")
                    {
                        dragons[type][name].Health = double.Parse(health);
                    }
                    if (armor != "null")
                    {
                        dragons[type][name].Armor = double.Parse(armor);
                    }
                }
            }

            foreach (var dragonTYPE in dragons)
            {
                double averageHealth = dragonTYPE.Value.Sum(x => x.Value.Health) / dragonTYPE.Value.Count();
                double averageDamage = dragonTYPE.Value.Sum(x => x.Value.Damage) / dragonTYPE.Value.Count();
                double averageArmor = dragonTYPE.Value.Sum(x => x.Value.Armor) / dragonTYPE.Value.Count();

                Console.WriteLine($"{dragonTYPE.Key}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                Console.WriteLine(string.Join(Environment.NewLine, dragonTYPE.Value.Select(x => $"-{x.Key} -> damage: {x.Value.Damage}, health: {x.Value.Health}, armor: {x.Value.Armor}")));
            }
        }

        public class Dragon
        {
            public Dragon()
            {
                this.Damage = 45;
                this.Armor = 10;
                this.Health = 250;
            }
            public double Damage { get; set; }
            public double Health { get; set; }
            public double Armor { get; set; }
        }
    }
}
