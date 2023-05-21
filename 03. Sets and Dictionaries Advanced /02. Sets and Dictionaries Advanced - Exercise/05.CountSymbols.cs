//INPUT
string text = Console.ReadLine();

//ACTION
SortedDictionary<char, int> charsAndRepeats = new SortedDictionary<char, int>();

for (int i = 0; i < text.Length; i++)
{
	if (charsAndRepeats.ContainsKey(text[i]))
	{
		charsAndRepeats[text[i]]++;
	}
	else
	{
        charsAndRepeats.Add(text[i], 1);
    }
}

foreach (var (character, repeats) in charsAndRepeats)
{
	Console.WriteLine($"{character}: {repeats} time/s");
}