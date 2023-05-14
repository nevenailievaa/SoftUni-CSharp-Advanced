using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

//INPUT
int foodQuantity = int.Parse(Console.ReadLine());
int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

//ACTION
Queue<int> ordersQueue = new Queue<int>(orders);
Console.WriteLine(ordersQueue.Max());

for (int i = 0; i < orders.Length; i++)
{
	if (foodQuantity - ordersQueue.Peek() >= 0)
	{
        foodQuantity -= ordersQueue.Dequeue();
    }
	else
	{
		break;
	}
}

//OUTPUT
if (ordersQueue.Count == 0)
{
	Console.WriteLine("Orders complete");	
}
else
{
	Console.WriteLine($"Orders left: {String.Join(" ", ordersQueue)}");
}