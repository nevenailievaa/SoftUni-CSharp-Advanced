//INPUT
Queue<int> tools = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray());

Stack<int> substances = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray());

List<int> challengesArray = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

//ACTION
while (tools.Any() && substances.Any() && challengesArray.Count > 0)
{
    int sum = tools.Peek() * substances.Peek();

    if (challengesArray.Contains(sum))
    {
        tools.Dequeue();
        substances.Pop();
        challengesArray.Remove(sum);
    }
    else
    {
        int toolToMove = tools.Dequeue() + 1;
        tools.Enqueue(toolToMove);

        int substanceToDecrease = substances.Pop() - 1;
        if (substanceToDecrease > 0)
        {
            substances.Push(substanceToDecrease);
        }
    }
}

//OUTPUT
if (challengesArray.Count > 0)
{
    Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
}
else
{
    Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
}

//Print
if (tools.Any())
{
    Console.Write("Tools: ");
    Console.WriteLine(String.Join(", ", tools));
}
if (substances.Any())
{
    Console.Write("Substances: ");
    Console.WriteLine(String.Join(", ", substances));
}
if (challengesArray.Count > 0)
{
    Console.Write("Challenges: ");
    Console.WriteLine(String.Join(", ", challengesArray));
}