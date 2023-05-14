using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

//INPUT
int greenLightDuration = int.Parse(Console.ReadLine());
int windowDuration = int.Parse(Console.ReadLine());

//ACTION
Queue<StringBuilder> cars = new Queue<StringBuilder>();
int carsPassedCounter = 0;

string command = string.Empty;
while ((command = Console.ReadLine()) != "END")
{
    if (command == "green")
	{
        int remainingSeconds = greenLightDuration;

        while (remainingSeconds > 0 && cars.Count > 0)
        {
            StringBuilder currentCar = cars.Dequeue();
            string currentCarString = currentCar.ToString();

            if (currentCar.Length <= remainingSeconds)
            {
                remainingSeconds -= currentCar.Length;
                carsPassedCounter++;
            }
            else
            {
                currentCar.Remove(0, remainingSeconds);
                remainingSeconds = 0;

                if (currentCar.Length <= windowDuration)
                {
                    carsPassedCounter++;
                }
                else
                {
                    char hitAtChar = currentCar[windowDuration];
                    Console.WriteLine("A crash happened!");
                    Console.WriteLine($"{currentCarString} was hit at {hitAtChar}.");
                    return;
                }
            }
        }
    }
	else
	{
		StringBuilder currentCar = new StringBuilder(command);
		cars.Enqueue(currentCar);
    }
}

//OUTPUT
Console.WriteLine("Everyone is safe.");
Console.WriteLine($"{carsPassedCounter} total cars passed the crossroads.");