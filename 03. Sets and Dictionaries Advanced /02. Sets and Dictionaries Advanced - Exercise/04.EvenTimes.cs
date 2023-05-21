//INPUT
int numbersCount = int.Parse(Console.ReadLine());

//ACTION
Dictionary<int,int> numbers = new Dictionary<int, int>();

for (int i = 0; i < numbersCount; i++)
{
    int currentNum = int.Parse(Console.ReadLine());

	if (numbers.ContainsKey(currentNum))
	{
		numbers[currentNum]++;
	}
	else
	{
		numbers.Add(currentNum, 1);
	}
}

//OUTPUT
foreach (var number in numbers)
{
	if (number.Value % 2 == 0)
	{
		Console.WriteLine(number.Key);
		return;
	}
}