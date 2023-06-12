//INPUT
Queue<int> tasksTimes = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray());

//INPUT
Stack<int> taskCounts = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray());

Dictionary<string, int> programmersDucks = new Dictionary<string, int>()
{
    {"Darth Vader Ducky", 0},
    {"Thor Ducky", 0},
    {"Big Blue Rubber Ducky", 0},
    {"Small Yellow Rubber Ducky", 0}
};


//ACTION
while (tasksTimes.Any() && taskCounts.Any())
{
    int timeCalculated = tasksTimes.Peek() * taskCounts.Peek();
    bool isValid = false;

    //Darth Vader Ducky
    if (timeCalculated >= 0 && timeCalculated <= 60)
    {
        programmersDucks["Darth Vader Ducky"] += 1;
        isValid = true;
    }

    //Thor Ducky
    else if (timeCalculated >= 61 && timeCalculated <= 120)
    {
        programmersDucks["Thor Ducky"] += 1;
        isValid = true;
    }

    //Big Blue Rubber Ducky
    else if (timeCalculated >= 121 && timeCalculated <= 180)
    {
        programmersDucks["Big Blue Rubber Ducky"] += 1;
        isValid = true;
    }

    //Small Yellow Rubber Ducky
    else if (timeCalculated >= 181 && timeCalculated <= 240)
    {
        programmersDucks["Small Yellow Rubber Ducky"] += 1;
        isValid = true;
    }

    //Above The Highest Range
    else if (timeCalculated > 240)
    {
        int value = taskCounts.Pop() - 2;
        taskCounts.Push(value);

        value = tasksTimes.Dequeue();
        tasksTimes.Enqueue(value);
    }

    //Checking
    if (isValid)
    {
        tasksTimes.Dequeue();
        taskCounts.Pop();
    }
}

//OUTPUT
Console.WriteLine("Congratulations, all tasks have been completed! Rubber ducks rewarded:");

foreach (var item in programmersDucks)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}