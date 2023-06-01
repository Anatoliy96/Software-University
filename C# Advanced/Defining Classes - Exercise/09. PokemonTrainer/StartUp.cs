using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Startup
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();

            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "Tournament")
            {
                Trainer trainer = trainers.SingleOrDefault(t => t.Name == input[0]);

                if (trainer == null)
                {
                    trainer = new Trainer(input[0]);
                    trainer.Pokemons.Add(new(input[1], input[2], int.Parse(input[3])));
                    trainers.Add(trainer);
                }
                else
                {
                    trainer.Pokemons.Add(new(input[1], input[2], int.Parse(input[3])));
                }

                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            string secondInput = Console.ReadLine();

            while (secondInput != "End")
            {
                foreach (var trainer in trainers)
                {
                    trainer.CheckPokemon(secondInput);
                }
                secondInput = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(b => b.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }

}