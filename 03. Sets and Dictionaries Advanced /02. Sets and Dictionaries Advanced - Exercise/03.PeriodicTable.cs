//INPUT
int elementsCount = int.Parse(Console.ReadLine());

//ACTION
HashSet<string> elements = new HashSet<string>();

for (int i = 0; i < elementsCount; i++)
{
    string[] currentElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    for (int j = 0; j < currentElements.Length; j++)
    {
        elements.Add(currentElements[j]);
    }
}

//OUTPUT
Console.WriteLine(String.Join(" ", elements.OrderBy(x => x)));