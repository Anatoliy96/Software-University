using System;
using System.Collections.Generic;

namespace _12._Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string heroName = input[0];
                int hp = int.Parse(input[1]);
                int mp = int.Parse(input[2]);

                if (!heroes.ContainsKey(heroName))
                {
                    heroes.Add(heroName, new Hero());

                    heroes[heroName].HP = hp;
                    heroes[heroName].MP = mp;
                }
            }

            string[] command = Console.ReadLine().Split(" - ");

            while (command[0] != "End")
            {
                if (command[0] == "CastSpell")
                {
                    string heroName = command[1];
                    int mpNeeded = int.Parse(command[2]);
                    string spell = command[3];

                    if (heroes.ContainsKey(heroName))
                    {
                        if (heroes[heroName].MP >= mpNeeded)
                        {
                            heroes[heroName].MP -= mpNeeded;

                            Console.WriteLine($"{heroName} has successfully cast {spell} and now has {heroes[heroName].MP} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} does not have enough MP to cast {spell}!");
                        }
                    }
                }
                else if (command[0] == "TakeDamage")
                {
                    string heroName = command[1];
                    int damage = int.Parse(command[2]);
                    string attacker = command[3];

                    if (heroes.ContainsKey(heroName))
                    {
                        heroes[heroName].HP -= damage;

                        if (heroes[heroName].HP > 0)
                        {
                            Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName].HP} HP left!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} has been killed by {attacker}!");
                            heroes.Remove(heroName);
                        }
                    }
                }
                else if (command[0] == "Recharge")
                {
                    string heroName = command[1];
                    int amount = int.Parse(command[2]);

                    if (heroes.ContainsKey(heroName))
                    {
                        int maxMp = 200;
                        int recharge = maxMp - heroes[heroName].MP;

                        heroes[heroName].MP += amount;

                        if (heroes[heroName].MP > maxMp)
                        {
                            Console.WriteLine($"{heroName} recharged for {recharge} MP!");
                            heroes[heroName].MP = maxMp;
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} recharged for {amount} MP!");
                        }
                    }
                }
                else if (command[0] == "Heal")
                {
                    string heroName = command[1];
                    int amount = int.Parse (command[2]);

                    if (heroes.ContainsKey(heroName))
                    {
                        int maxHp = 100;
                        int heal = maxHp - heroes[heroName].HP;

                        heroes[heroName].HP += amount;

                        if (heroes[heroName].HP > maxHp)
                        {
                            Console.WriteLine($"{heroName} healed for {heal} HP!");
                            heroes[heroName].HP = maxHp;
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} healed for {amount} HP!");
                        }
                    }
                }

                command = Console.ReadLine().Split(" - ");
            }

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value.HP}");
                Console.WriteLine($"  MP: {hero.Value.MP}");
            }
        }

        public class Hero
        {
            public int HP { get; set; }
            public int MP { get; set; }
        }
    }
}
