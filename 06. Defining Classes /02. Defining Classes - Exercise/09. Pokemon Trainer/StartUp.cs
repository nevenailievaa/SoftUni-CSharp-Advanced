using System.Security;
using System.Security.Cryptography.X509Certificates;

namespace DefiningClasses;

public class StartUp
{
    static void Main(string[] args)
    {
        //INPUT
        string command = string.Empty;

        //Creating The Trainers
        List<Trainer> trainers = new List<Trainer>();

        while ((command = Console.ReadLine()) != "Tournament")
        {
            string[] info = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string trainerName = info[0];
            string pokemonName = info[1];
            string pokemonElement = info[2];
            int pokemonHealth = int.Parse(info[3]);

            Trainer currentTrainer = trainers.SingleOrDefault(t => t.Name == trainerName);

            if (currentTrainer == null)
            {
                trainers.Add(CreateTrainer(trainerName, 0, (CreatePokemon(pokemonName, pokemonElement, pokemonHealth))));
            }
            else
            {
                currentTrainer.Pokemons.Add(CreatePokemon(pokemonName, pokemonElement, pokemonHealth));
            }
        }

        //Elements Filtering
        while ((command = Console.ReadLine()) != "End")
        {
            foreach (Trainer trainer in trainers)
            {
                trainer.CheckPokemon(command);
            }
        }

        //OUTPUT
        foreach (Trainer trainer in trainers.OrderByDescending(t => t.BadgesCount))
        {
            Console.WriteLine($"{trainer.Name} {trainer.BadgesCount} {trainer.Pokemons.Count}");
        }

        //Creating Pokemon Method
        static Pokemon CreatePokemon(string name, string element, int health)
        {
            Pokemon pokemon = new Pokemon(name, element, health);
            return pokemon;
        }

        //Creating Trainer Method
        static Trainer CreateTrainer(string name, int badges, Pokemon pokemon)
        {
            List<Pokemon> pokemons = new List<Pokemon>();
            pokemons.Add(pokemon);

            Trainer trainer = new Trainer(name, badges, pokemons);
            return trainer;
        }
    }
}



