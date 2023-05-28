//INPUT
Func<string, int[]> readIntegers = input => input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
.Select(int.Parse)
.ToArray();

int[] inputNumbers = readIntegers(Console.ReadLine());
int lowerBond = inputNumbers[0];
int upperBond = inputNumbers[1];

//ACTION
string command = Console.ReadLine();
Predicate<int> numbersSelector = number =>
{
    if (command == "even")
    {
        return number % 2 == 0;
    }
    else if (command == "odd")
    {
        return number % 2 != 0;
    }
    return false;
};

List<int> outputNumbers = new List<int>();

for (int i = lowerBond; i <= upperBond; i++)
{
    if (numbersSelector(i))
    {
        outputNumbers.Add(i);
    }
}

//OUTPUT
Console.WriteLine(String.Join(" ", outputNumbers));