using ComparingObjects;
using System;

string command = string.Empty;
List<Person> people = new List<Person>();

while ((command = Console.ReadLine()) != "END")
{
    string[] personInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    Person currentPerson = new Person(personInfo[0], int.Parse(personInfo[1]), personInfo[2]);
    people.Add(currentPerson);
}

int index = int.Parse(Console.ReadLine()) -1;
Person personToCompare = people[index];

int matchesCount = 0;

foreach(Person person in people)
{
    if (person.CompareTo(personToCompare) == 0)
    {
        matchesCount++;
    }
}
if (matchesCount == 1)
{
    Console.WriteLine("No matches");
}
else
{
    Console.WriteLine($"{matchesCount} {people.Count-matchesCount} {people.Count}");
}