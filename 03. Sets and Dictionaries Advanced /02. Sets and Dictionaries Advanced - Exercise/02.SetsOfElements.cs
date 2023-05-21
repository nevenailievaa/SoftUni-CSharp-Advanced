//INPUT
int[] lengths = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int setOneLength = lengths[0];
int setTwoLength = lengths[1];

//ACTION
HashSet<int> setOne = new HashSet<int>();
HashSet<int> setTwo = new HashSet<int>();
HashSet<int> repeatElements = new HashSet<int>();

//First Set
for (int i = 0; i < setOneLength; i++)
{
    setOne.Add(int.Parse(Console.ReadLine()));
}

//Second Set
for (int j = 0; j < setTwoLength; j++)
{
    setTwo.Add(int.Parse(Console.ReadLine()));
}

//Repeated Elements Finder
if (setOneLength >= setTwoLength)
{
    foreach (var num in setOne)
    {
        if (setTwo.Contains(num))
        {
            repeatElements.Add(num);
        }
    }
}
else
{
    for (int i = 0; i < setTwoLength; i++)
    {
        foreach (var num in setTwo)
        {
            if (setOne.Contains(num))
            {
                repeatElements.Add(num);
            }
        }
    }
}

//OUTPUT
Console.WriteLine(String.Join(" ", repeatElements));