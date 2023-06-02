using System.Text;

namespace DefiningClasses;

public class Car
{
    public string Model { get; set; }
    public Engine Engine { get; set; }
    public int Weight { get; set; }
    public string Color { get; set; }

    //Constructors
    public Car(string model, Engine engine)
    {
        Model = model;
        Engine = engine;
    }
    public Car(string model, Engine engine, int weight, string color) :this(model, engine)
    {
        Weight = weight;
        Color = color;
    }

    //ToString Method
    public override string ToString()
    {
        string weight = Weight == 0 ? "n/a" : Weight.ToString();
        string color = Color ?? "n/a";


        StringBuilder sb = new();

        sb.AppendLine($"{Model}:");
        sb.AppendLine($"  {Engine.ToString()}");
        sb.AppendLine($"  Weight: {weight}");
        sb.AppendLine($"  Color: {color}");

        return sb.ToString().TrimEnd();
    }
}
