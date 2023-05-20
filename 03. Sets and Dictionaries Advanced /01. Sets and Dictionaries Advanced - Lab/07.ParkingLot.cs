//INPUT
string command = string.Empty;

//ACTION
HashSet<string> parking = new HashSet<string>();

while((command = Console.ReadLine()) != "END")
{
    string[] carInfo = command.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    string carDirection = carInfo[0];
    string carNumber = carInfo[1];

    if (carDirection == "IN")
    {
        parking.Add(carNumber);
    }
    else if (carDirection == "OUT")
    {
        if (parking.Contains(carNumber))
        {
            parking.Remove(carNumber);
        }
    }
}

//OUTPUT
if (parking.Count > 0)
{
    foreach (var name in parking)
    {
        Console.WriteLine(name);
    }
}
else
{
    Console.WriteLine("Parking Lot is Empty");
}