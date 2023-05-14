using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

//INPUT
int petrolPumpsCnt = int.Parse(Console.ReadLine());

//ACTION
Queue<int[]> stops = new Queue<int[]>();

for (int i = 0; i < petrolPumpsCnt; i++)
{
    int[] petrolPumps = Console.ReadLine().Split().Select(int.Parse).ToArray();
    stops.Enqueue(petrolPumps);
}

bool isValid = false;
int truckFuel = 0;
int validXTimes = petrolPumpsCnt;
int stopIndex = -1;

while (true)
{
    if (!isValid)
    {
        stopIndex++;
    }

    int[] currentInfo = stops.Dequeue();
    int currentFuel = currentInfo[0];
    int kmToNextPump = currentInfo[1];
    stops.Enqueue(currentInfo);

    truckFuel += currentFuel;
    truckFuel -= kmToNextPump;

    if (truckFuel < 0)
    {
        isValid = false;
        truckFuel = 0;
        stopIndex = stopIndex + (stops.Count - validXTimes);
        validXTimes = petrolPumpsCnt;
        continue;
    }
    else
    {
        validXTimes -= 1;
        isValid = true;
        if (validXTimes == 0)
        {
            //OUTPUT
            Console.WriteLine(stopIndex);
            return;
        }
    }
}