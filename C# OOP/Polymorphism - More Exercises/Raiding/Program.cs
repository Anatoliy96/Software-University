using Raiding.Models;

namespace Raiding
{
    public class StartUp
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            string type = string.Empty;

            List<BaseHero> heroes = new List<BaseHero>();
            int heroesPower = 0;

            for (int i = 0; i < input; i++)
            {
                string name = Console.ReadLine();
                type = Console.ReadLine();

                if (type == "Paladin")
                {
                    BaseHero paladin = new Paladin(name);

                    heroes.Add(paladin);
                }
                else if (type == "Druid")
                {
                    BaseHero druid = new Druid(name);

                    heroes.Add(druid);
                }
                else if (type == "Rogue")
                {
                    BaseHero rogue = new Rogue(name);

                    heroes.Add(rogue);
                }
                else if (type == "Warrior")
                {
                    BaseHero warrior = new Warrior(name);

                    heroes.Add(warrior);
                }
            }

            int bossPower = int.Parse(Console.ReadLine());

            foreach (var hero in heroes)
            {
                if (type != "Paladin" && type != "Druid" && type != "Rogue" && type != "Warrior")
                {
                    Console.WriteLine("Invalid hero!");
                }

                Console.WriteLine(hero.CastAbility());
                heroesPower += hero.Power;
            }

            if (heroesPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
