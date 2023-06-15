namespace Zoo
{
    public class Animal
    {
        //Contructor
        public Animal(string species, string diet, double weight, double length)
        {
            Species = species;
            Diet = diet;
            Weight = weight;
            Length = length;
        }

        //Properties
        public string Species { get; private set; }
        public string Diet { get; private set; }
        public double Weight { get; private set; }
        public double Length { get; private set; }

        //Methods
        public override string ToString()
        {
            return $"The {Species} is a {Diet} and weighs {Weight} kg.";
        }
    }
}