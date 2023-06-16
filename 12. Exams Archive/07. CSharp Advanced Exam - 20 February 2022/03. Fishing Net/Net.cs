using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FishingNet
{
    public class Net
    {
        //Properties
        public List<Fish> Fish { get; set; }
        public string Material { get; private set; }
        public int Capacity { get; private set; }
        public int Count => Fish.Count;

        //Constructor
        public Net(string material, int capacity)
        {
            Material = material;
            Capacity = capacity;
            Fish = new List<Fish>();
        }

        //Methods
        public string AddFish(Fish fish)
        {
            if (string.IsNullOrWhiteSpace(fish.FishType) || fish.Length <= 0 || fish.Weight <= 0)
            {
                return "Invalid fish.";
            }
            else if (Fish.Count == Capacity)
            {
                return "Fishing net is full.";
            }

            Fish.Add(fish);
            return $"Successfully added {fish.FishType} to the fishing net.";
        }

        public bool ReleaseFish(double weight) => Fish.Remove(Fish.Find(f => f.Weight == weight));

        public Fish GetFish(string fishType) => Fish.Find(f => f.FishType == fishType);

        public Fish GetBiggestFish() => Fish.Find(x => x.Weight == Fish.Max(y => y.Weight));

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Into the {Material}:");

            foreach (Fish fish in Fish.OrderByDescending(f => f.Length))
            {
                sb.AppendLine(fish.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}