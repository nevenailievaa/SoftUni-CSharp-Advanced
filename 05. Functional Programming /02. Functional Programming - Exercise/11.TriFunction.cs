//INPUT
int givenSum = int.Parse(Console.ReadLine());
string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

foreach (string name in names)
{
    Func<string, int, bool> isValidName = (name, nameLength) =>
    {
        int nameSum = 0;
        for (int i = 0; i < nameLength; i++)
        {
            nameSum += name[i];
        }
        return nameSum >= givenSum;
    };

    if (isValidName(name, name.Length))
    {
        Console.WriteLine(name);
        return;
    }
}