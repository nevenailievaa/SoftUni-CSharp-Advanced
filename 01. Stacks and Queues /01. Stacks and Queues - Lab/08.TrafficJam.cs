//INPUT
int carsForGreenLight = int.Parse(Console.ReadLine());

//ACTION
Queue<string> cars = new Queue<string>();
int passedCarsSum = 0;

string command = string.Empty;
while ((command = Console.ReadLine()) != "end")
{
	if (command != "green")
	{
		cars.Enqueue(command);
	}
	else
	{
		if (cars.Count == 0)
		{
            continue;
        }
		for (int i = 1; i <= carsForGreenLight; i++)
		{
			string currentPassingCar = cars.Dequeue();
			Console.WriteLine($"{currentPassingCar} passed!");
			passedCarsSum++;

			if (cars.Count == 0)
			{
				break;
			}
		}
	}
}

//OUTPUT
Console.WriteLine($"{passedCarsSum} cars passed the crossroads.");