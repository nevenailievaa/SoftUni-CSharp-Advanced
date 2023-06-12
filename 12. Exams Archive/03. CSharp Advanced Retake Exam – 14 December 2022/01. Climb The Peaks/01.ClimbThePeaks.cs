//INPUT
Stack<int> food = new Stack<int>(Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray());

Queue<int> stamina = new Queue<int>(Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray());

Queue<string> peaks = new Queue<string>();
peaks.Enqueue("Vihren");
peaks.Enqueue("Kutelo");
peaks.Enqueue("Banski Suhodol");
peaks.Enqueue("Polezhan");
peaks.Enqueue("Kamenitza");

Queue<string> climbedPeaks = new Queue<string>();
int day = 0;

//ACTION
while (food.Any() && stamina.Any() && peaks.Any())
{
    int sum = food.Peek() + stamina.Peek();
    string firstPeak = peaks.Peek();
    bool isConquered = false;
    string peak = string.Empty;
    day += 1;

    if (firstPeak == "Vihren")
    {
        if (sum >= 80)
        {
            peak = peaks.Dequeue();
            climbedPeaks.Enqueue(peak);
            isConquered = true;
        }
    }
    else if (firstPeak == "Kutelo")
    {
        if (sum >= 90)
        {
            peak = peaks.Dequeue();
            climbedPeaks.Enqueue(peak);
            isConquered = true;
        }
    }
    else if (firstPeak == "Banski Suhodol")
    {
        if (sum >= 100)
        {
            peak = peaks.Dequeue();
            climbedPeaks.Enqueue(peak);
            isConquered = true;
        }
    }
    else if (firstPeak == "Polezhan")
    {
        if (sum >= 60)
        {
            peak = peaks.Dequeue();
            climbedPeaks.Enqueue(peak);
            isConquered = true;
        }
    }
    else if (firstPeak == "Kamenitza")
    {
        if (sum >= 70)
        {
            peak = peaks.Dequeue();
            climbedPeaks.Enqueue(peak);
            isConquered = true;
        }
    }

    food.Pop();
    stamina.Dequeue();

    //Day
    if (day == 7)
    {
        break;
    }
}

//OUTPUT
if (!peaks.Any())
{
    Console.WriteLine($"Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
}
else
{
    Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");
}

if (climbedPeaks.Any())
{
    Console.WriteLine("Conquered peaks:");
    foreach (var peak in climbedPeaks)
    {
        Console.WriteLine(peak);
    }
}