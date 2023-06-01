namespace DefiningClasses;

internal class StartUp
{
    static void Main(string[] args)
    {
        //INPUT
        int peopleCount = int.Parse(Console.ReadLine());

        //ACTION
        Family familyList = new Family();

        for (int i = 0; i < peopleCount; i++)
        {
            string[] currentPersonInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string currentName = currentPersonInfo[0];
            int currentAge = int.Parse(currentPersonInfo[1]);

            Person person = new Person()
            {
                Name = currentName,
                Age = currentAge
            };

            familyList.AddMember(person);
        }

        //OUTPUT
        Person oldestPerson = familyList.GetOldestMember();
        Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
    }
}