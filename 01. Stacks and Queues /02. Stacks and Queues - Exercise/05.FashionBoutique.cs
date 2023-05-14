using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

//INPUT
int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rackCapacity = int.Parse(Console.ReadLine());

Stack<int> clothesStack = new Stack<int>(clothes);
int clothesSum = 0;
int racksCnt = 1;

while (clothesStack.Count > 0)
{
	if (clothesSum + clothesStack.Peek() < rackCapacity)
	{
		clothesSum += clothesStack.Pop();
    }
	else if (clothesSum + clothesStack.Peek() == rackCapacity)
	{
		clothesSum += clothesStack.Pop();

		if (clothesStack.Count > 0)
		{
			clothesSum = 0;
			racksCnt++;
        }
    }
	else if (clothesSum + clothesStack.Peek() > rackCapacity)
    {
		clothesSum = 0;
		racksCnt++;
    }
}

//OUTPUT
Console.WriteLine(racksCnt);