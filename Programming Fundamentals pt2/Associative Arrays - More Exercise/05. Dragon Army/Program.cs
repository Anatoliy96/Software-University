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

            Dictionary<string, List<Dragon>> dragons = new Dictionary<string, List<Dragon>>();
            
            int defaultHealth = 250;
            int defaultDamage = 45;
            int defaultArmor = 10;

            double averageDamage = 0;
            double averageArmor = 0;
            double averageHealth = 0;

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ');

                string type = command[0];
                string name = command[1];
                string damage = command[2];
                string health = command[3];
                string armor = command[4];

                if (damage == "null")
                {
                    damage = defaultDamage.ToString();
                    defaultDamage = int.Parse(damage);
                }
                if (health == "null")
                {
                    health = defaultHealth.ToString();
                    defaultHealth = int.Parse(health);
                }
                if (armor == "null")
                {
                    armor = defaultArmor.ToString();
                    defaultArmor = int.Parse(armor);
                }

                Dragon dragon = new Dragon();

                dragon.Name = name;
                dragon.Damage = int.Parse(damage);
                dragon.Health = int.Parse(health);
                dragon.Armor = int.Parse(armor);

                foreach (var kvp in dragons)
                {
                    foreach (var drg in kvp.Value)
                    {
                        if (kvp.Key == type && drg.Name == name)
                        {
                            drg.Damage = int.Parse(damage);
                            drg.Health = int.Parse(health);
                            drg.Armor = int.Parse(armor);

                            continue;
                        }
                    }
                }

                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new List<Dragon>());
                }

                dragons[type].Add(dragon);
            }

            foreach (var dragon in dragons)
            {
                foreach (var drg in dragon.Value)
                {
                    averageDamage += drg.Damage;
                    averageArmor += drg.Armor;
                    averageHealth += drg.Health;
                }

                averageDamage /= dragon.Value.Count;
                averageHealth /= dragon.Value.Count;
                averageArmor /= dragon.Value.Count;

                Console.WriteLine($"{dragon.Key}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                foreach (var drg in dragon.Value.OrderBy(d => d.Name))
                {
                    Console.WriteLine($"-{drg.Name} -> damage: {drg.Damage}, health: {drg.Health}, armor: {drg.Armor}");
                }

                averageDamage = 0;
                averageHealth = 0;
                averageArmor = 0;
            }
        }

        public class Dragon
        {
            public string Name { get; set; }
            public int Damage { get; set; }
            public int Health { get; set; }
            public int Armor { get; set; }
        }
    }
}
