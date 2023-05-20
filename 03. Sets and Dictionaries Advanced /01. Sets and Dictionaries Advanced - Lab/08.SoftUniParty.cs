//INPUT
string command = string.Empty;

//ACTION
HashSet<string> guests = new HashSet<string>();
HashSet<string> vipGuests = new HashSet<string>();

//Invited People List
while ((command = Console.ReadLine()) != "PARTY")
{
    string currentGuest = command;

	if (Char.IsDigit(currentGuest[0]))
	{
		vipGuests.Add(currentGuest);
	}
	else
	{
        guests.Add(currentGuest);
    }
}

//Partying People
while ((command = Console.ReadLine()) != "END")
{
    string currentGuest = command;

    if (Char.IsDigit(currentGuest[0]))
    {
        vipGuests.Remove(currentGuest);
    }
    else
    {
        guests.Remove(currentGuest);
    }
}

//OUTPUT
Console.WriteLine(vipGuests.Count + guests.Count);

if (vipGuests.Count > 0)
{
    foreach (var vipGuest in vipGuests)
    {
        Console.WriteLine(vipGuest);
    }
}
if (guests.Count > 0)
{
    foreach (var guest in guests)
    {
        Console.WriteLine(guest);
    }
}