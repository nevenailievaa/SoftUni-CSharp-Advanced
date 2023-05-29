//INPUT
List<string> guests = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

//ACTION
string command = string.Empty;

while ((command = Console.ReadLine()) != "Party!")
{
    string[] commandArray = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    string commandType = commandArray[0];
    string commandCriteria = commandArray[1];

    //Predicate
    Predicate<string> nameFunc = name =>
    {
        if (commandCriteria == "StartsWith")
        {
            return name.StartsWith(commandArray[2]);
        }
        else if (commandCriteria == "EndsWith")
        {
            return name.EndsWith(commandArray[2]);
        }
        else if (commandCriteria == "Length")
        {
            return name.Length == int.Parse(commandArray[2]);
        }
        return false;
    };


    //Double Command
    if (commandType == "Double")
    {
        for (int i = 0; i < guests.Count; i++)
        {
            if (nameFunc(guests[i]))
            {
                guests.Insert(i, guests[i]);
                i++;
            }
        }
    }
    //Remove Command
    else if (commandType == "Remove")
    {
        for (int i = 0; i < guests.Count; i++)
        {
            if (nameFunc(guests[i]))
            {
                guests.RemoveAt(i);
                i--;
            }
        }
    }
}

//OUTPUT
if (guests.Count > 0)
{
    Console.Write(String.Join(", ", guests));
    Console.Write(" are going to the party!");
}
else
{
    Console.WriteLine("Nobody is going to the party!");
}
