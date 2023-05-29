//INPUT
List<string> invitedPeople = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

//ACTION
List<string> filtersAsStrings = new List<string>();
string command = string.Empty;

while ((command = Console.ReadLine()) != "Print")
{
    string[] commandArray = command.Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();
    string commandType = commandArray[0];
    string filterType = commandArray[1];
    string filterParameter = commandArray[2];

    //Adding Filter String
    if (commandType == "Add filter")
    {
        filtersAsStrings.Add((filterType + ";" + filterParameter));
    }
    //Removing Filter String
    else if (commandType == "Remove filter")
    {
        filtersAsStrings.Remove(filterType + ";" + filterParameter);
    }
}


//Predicates
List<Predicate<string>> filters = new List<Predicate<string>>();

for (int i = 0; i < filtersAsStrings.Count; i++)
{
    string[] filterArray = filtersAsStrings[i].Split(";").ToArray();
    string filterType = filterArray[0];
    string filterParameter = filterArray[1];

    Predicate<string> nameFilter = name =>
    {
        if (filterType == "Starts with")
        {
            return name.StartsWith(filterParameter);
        }
        else if (filterType == "Ends with")
        {
            return name.EndsWith(filterParameter);
        }
        else if (filterType == "Length")
        {
            return name.Length == int.Parse(filterParameter);
        }
        else if (filterType == "Contains")
        {
            return name.Contains(filterParameter);
        }
        return false;
    };
    filters.Add(nameFilter);
}


//Names Filtering
for (int i = 0; i < invitedPeople.Count; i++)
{
    string currentName = invitedPeople[i];
    bool isValid = true;

    for (int j = 0; j < filters.Count; j++)
    {
        Predicate<string> currentFilter = filters[j];

        if (currentFilter(currentName))
        {
            isValid = false;
            invitedPeople.RemoveAt(i);
            i--;
            break;
        }
    }
}

//OUTPUT
Console.WriteLine(String.Join(" ", invitedPeople));