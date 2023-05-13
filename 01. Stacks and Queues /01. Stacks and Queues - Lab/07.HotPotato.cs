//INPUT
List<string> kidsArray = Console.ReadLine().Split().ToList();
int repeats = int.Parse(Console.ReadLine());

//ACTION
Queue<string> kids = new Queue<string>(kidsArray);

while (kids.Count != 1)
{
    for (int i = 1; i < repeats; i++)
    {
        string currentKid = kids.Dequeue();
        kids.Enqueue(currentKid);
    }

    string removedKid = kids.Dequeue();
    Console.WriteLine($"Removed {removedKid}");
}

//OUTPUT
Console.WriteLine($"Last is {kids.Dequeue()}");