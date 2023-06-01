namespace DefiningClasses;
public class StartUp
{
    static void Main(string[] args)
    {
        Person defaultPerson = new Person();

        Person personCustomAge = new Person();
        personCustomAge.Age = 20;

        Person customPerson = new Person();
        customPerson.Name = "Nevena";
        customPerson.Age = 19;

        Console.WriteLine($"Default data person's name is {defaultPerson.Name} and is {defaultPerson.Age} years old.");

        Console.WriteLine($"Custom age person's name is {personCustomAge.Name} and is {personCustomAge.Age} years old.");

        Console.WriteLine($"Custom person's name is {customPerson.Name} and is {customPerson.Age} years old.");
    }
}