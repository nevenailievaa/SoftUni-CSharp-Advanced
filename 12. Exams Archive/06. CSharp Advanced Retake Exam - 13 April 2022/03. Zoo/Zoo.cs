using System.Collections.Generic;
using System.Linq;

namespace Zoo
{
    public class Zoo
    {
        //Constructor
        public Zoo(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Animals = new List<Animal>();
        }

        //Properties
        public List<Animal> Animals { get; set; }
        public string Name { get; private set; }
        public int Capacity { get; private set; }

        //Methods
        public string AddAnimal(Animal animal)
        {
            if (string.IsNullOrWhiteSpace(animal.Species))
            {
                return "Invalid animal species.";
            }
            else if (animal.Diet != "herbivore" && animal.Diet != "carnivore")
            {
                return "Invalid animal diet.";
            }
            else if (Animals.Count == Capacity)
            {
                return "The zoo is full.";
            }

            Animals.Add(animal);
            return $"Successfully added {animal.Species} to the zoo.";
        }

        public int RemoveAnimals(string species) => Animals.RemoveAll(a => a.Species == species);

        public List<Animal> GetAnimalsByDiet(string diet) => Animals.Where(a => a.Diet == diet).ToList();

        public Animal GetAnimalByWeight(double weight) => Animals.FirstOrDefault(a => a.Weight == weight);

        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
            List<Animal> animals = Animals.FindAll(a => a.Length >= minimumLength && a.Length <= maximumLength);
            return $"There are {animals.Count} animals with a length between {minimumLength} and {maximumLength} meters.";
        }
    }
}