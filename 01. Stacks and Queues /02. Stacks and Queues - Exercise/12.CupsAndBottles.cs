using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;

//INPUT
int[] cupsCapacities = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] waterBottles = Console.ReadLine().Split().Select(int.Parse).ToArray();

Queue<int> cupsQueue = new Queue<int>(cupsCapacities);
Stack<int> waterBottlesStack = new Stack<int>(waterBottles);

int wastedWater = 0;
while (waterBottlesStack.Any() && cupsQueue.Any())
{
    int currentCup = cupsQueue.Dequeue();
    int currentBottle = waterBottlesStack.Pop();

    currentCup -= currentBottle;

    if (currentCup <= 0)
    {
        wastedWater += Math.Abs(currentCup);
        continue;
    }

    while (currentCup > 0 && waterBottles.Any())
    {
        currentBottle = waterBottlesStack.Pop();
        currentCup -= currentBottle;

        if (currentCup <= 0)
        {
            wastedWater += Math.Abs(currentCup);
            break;
        }
    }
}

//OUTPUT
if (cupsQueue.Count == 0)
{
    Console.Write("Bottles: ");
    Console.WriteLine(String.Join(" ", waterBottlesStack));
}
else
{
    Console.Write("Cups: ");
    Console.WriteLine(String.Join(" ", cupsQueue));
}

Console.WriteLine($"Wasted litters of water: {wastedWater}");