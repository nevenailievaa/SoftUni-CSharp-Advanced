//INPUT
string currentInput = string.Empty;

//ACTION
Queue<string> names = new Queue<string>();

while ((currentInput = Console.ReadLine()) != "End")
{
	if (currentInput != "Paid")
	{
		names.Enqueue(currentInput);
	}
	else
	{
		Console.WriteLine(string.Join("\n", names));
		names.Clear();
	}
}

//OUTPUT
Console.WriteLine($"{names.Count} people remaining.");