//INPUT
Queue<int> textiles = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Stack<int> medicaments = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Dictionary<int, string> table = new Dictionary<int, string>()
{
    {30, "Patch"},
    {40, "Bandage"},
    {100, "MedKit"}
};

Dictionary<string, int> items = new Dictionary<string, int>();

//ACTION
while (textiles.Any() && medicaments.Any())
{
    int sum = textiles.Peek() + medicaments.Peek();

    if (table.ContainsKey(sum))
    {
        if (items.ContainsKey(table[sum]))
        {
            items[table[sum]] += 1;
        }
        else
        {
            items.Add(table[sum], 1);
        }

        textiles.Dequeue();
        medicaments.Pop();
    }
    else if (sum > 100)
    {
        if (items.ContainsKey("MedKit"))
        {
            items["MedKit"] += 1;
        }
        else
        {
            items.Add("MedKit", 1);
        }

        int remainingValue = sum - 100;
        textiles.Dequeue();
        medicaments.Pop();

        int valueToAddTo = medicaments.Peek() + remainingValue;
        medicaments.Pop();
        medicaments.Push(valueToAddTo);
    }
    else
    {
        textiles.Dequeue();
        int valueToAddTo = medicaments.Peek() + 10;
        medicaments.Pop();
        medicaments.Push(valueToAddTo);
    }
}

//OUTPUT
if (!textiles.Any() && !medicaments.Any())
{
    Console.WriteLine("Textiles and medicaments are both empty.");
}
else if (!textiles.Any())
{
    Console.WriteLine("Textiles are empty.");
}
else if (!medicaments.Any())
{
    Console.WriteLine("Medicaments are empty.");
}

if (items.Any())
{
    foreach (var item in items.OrderByDescending(i => i.Value).ThenBy(i => i.Key))
    {
        Console.WriteLine($"{item.Key} - {item.Value}");
    }
}

if (medicaments.Any())
{
    Console.Write("Medicaments left: ");
    Console.WriteLine(String.Join(", ", medicaments));
}
if (textiles.Any())
{
    Console.Write("Textiles left: ");
    Console.WriteLine(String.Join(", ", textiles));
}