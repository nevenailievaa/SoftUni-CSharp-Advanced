using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

//INPUT
int[] parameters = Console.ReadLine().Split().Select(int.Parse).ToArray();
int elementsToAddCnt = parameters[0];
int elementsToRemoveCnt = parameters[1];
int x = parameters[2];

//ACTION
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
Queue<int> queue = new Queue<int>(numbers);

for (int i = 1; i <= elementsToRemoveCnt; i++)
{
	if (queue.Count > 0)
	{
        queue.Dequeue();
    }
}

if (queue.Count == 0)
{
    Console.WriteLine(0);
}
else if (queue.Contains(x))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine(queue.Min());
}