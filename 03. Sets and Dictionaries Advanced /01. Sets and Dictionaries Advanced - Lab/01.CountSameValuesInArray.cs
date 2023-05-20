//INPUT
double[] numbersInput = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(double.Parse)
    .ToArray();

//ACTION
Dictionary<double, int> numbersOutput = new Dictionary<double, int>();

for (int i = 0; i < numbersInput.Length; i++)
{
    double currentNum = numbersInput[i];

    if (numbersOutput.ContainsKey(currentNum))
    {
        numbersOutput[currentNum]++;
    }
    else
    {
        numbersOutput.Add(currentNum, 1);
    }
}

//OUTPUT
foreach (var currentNum in numbersOutput)
{
    Console.WriteLine($"{currentNum.Key} - {currentNum.Value} times");
}