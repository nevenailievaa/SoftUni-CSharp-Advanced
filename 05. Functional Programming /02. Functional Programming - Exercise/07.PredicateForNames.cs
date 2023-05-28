//INPUT
int nameLength = int.Parse(Console.ReadLine());
string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

//ACTION
Predicate<string> nameChecker = name => name.Length <= nameLength;

//OUTPUT
List<string> validNames = new List<string>();
for (int i = 0; i < names.Length; i++)
{
	if (nameChecker(names[i]))
	{
		validNames.Add(names[i]);
	}
}

//OUTPUT
Console.WriteLine(string.Join("\n", validNames));