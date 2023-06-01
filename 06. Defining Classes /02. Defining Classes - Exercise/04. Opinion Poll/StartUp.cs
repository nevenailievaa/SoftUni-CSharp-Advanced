namespace DefiningClasses
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            //INPUT
            int count = int.Parse(Console.ReadLine());

            //ACTION
            List<Person> people = new List<Person>();

            for (int i = 0; i < count; i++)
            {
                string[] personInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);
                people.Add(new Person(name, age));
            }

            //OUTPUT
            foreach (var person in people.OrderBy(p => p.Name).Where(p => p.Age > 30))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}