using CustomStructures;

CustomStack stack = new CustomStack();
string command = String.Empty;

while ((command = Console.ReadLine()) != "End")
{
    string[] commandInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    string commandType = commandInfo[0];

    if (commandType == "Push")
    {
        int value = int.Parse(commandInfo[1]);
        stack.Push(value);

        Console.WriteLine($"Successfully pushed value {value} to the stack!");
    }
    else if (commandType == "Pop")
    {
        int value = stack.Pop();
        Console.WriteLine($"Successfully popped value {value} from the stack!");
    }
    else if (commandType == "Peek")
    {
        int value = stack.Peek();
        Console.WriteLine($"Last value is: {value}.");
    }
    else if (commandType == "ForEach")
    {
        stack.ForEach(item => Console.Write(item*2 + " "));
        Console.WriteLine();
        continue;
    }

    stack.Print();
}