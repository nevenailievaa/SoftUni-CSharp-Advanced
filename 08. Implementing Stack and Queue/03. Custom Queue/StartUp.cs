using CustomStructures;
using System.Xml.Linq;

CustomQueue queue = new CustomQueue();
string command = String.Empty;

while ((command = Console.ReadLine()) != "End")
{
    string[] commandInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    string commandType = commandInfo[0];

    if (commandType == "Enqueue")
    {
        int value = int.Parse(commandInfo[1]);
        queue.Enqueue(value);
        Console.WriteLine($"Successfully enqueued {value} to the queue!");
    }
    else if (commandType == "Dequeue")
    {
        int element = queue.Dequeue();

        if (queue.Count == 0)
        {
            Console.WriteLine("Queue is empty.");
            continue;
        }

        Console.WriteLine($"Successfully dequeued the first element of the queue! ({element})");
    }
    else if (commandType == "Peek")
    {
        int element = queue.Peek();
        Console.WriteLine($"The first element of the queue is: {element}.");
    }
    else if (commandType == "Clear")
    {
        queue.Clear();
        Console.WriteLine($"The queue has been succesfully cleared.");
        continue;
    }
    else if (commandType == "ForEach")
    {
        queue.ForEach(element => Console.Write(element*2 + " "));
        Console.WriteLine();
        continue;
    }

    queue.Print();
}