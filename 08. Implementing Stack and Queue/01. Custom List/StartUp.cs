using CustomStructures;

CustomList list = new CustomList();

string command = String.Empty;

while ((command = Console.ReadLine()) != "End")
{
    string[] commandInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    string commandType = commandInfo[0];

    if (commandType == "Add")
    {
        int value = int.Parse(commandInfo[1]);
        list.Add(value);
    }
    else if (commandType == "RemoveAt")
    {
        int index = int.Parse(commandInfo[1]);
        list.RemoveAt(index);
    }
    else if (commandType == "InsertAt")
    {
        int index = int.Parse(commandInfo[1]);
        int value = int.Parse(commandInfo[2]);
        list.InsertAt(index, value);
    }
    else if (commandType == "Contains")
    {
        int value = int.Parse(commandInfo[1]);
        list.Contains(value);
    }
    else if (commandType == "Swap")
    {
        int indexOne = int.Parse(commandInfo[1]);
        int indexTwo = int.Parse(commandInfo[2]);
        list.Swap(indexOne, indexTwo);
    }

    list.Print();
}