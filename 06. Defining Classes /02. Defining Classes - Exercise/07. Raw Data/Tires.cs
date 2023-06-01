namespace DefiningClasses;

internal class Tire
{
    public int Age { get; set; }
    public float Pressure { get; set; }

    public Tire(int age, float pressure)
    {
        Age = age;
        Pressure = pressure;
    }   
}
