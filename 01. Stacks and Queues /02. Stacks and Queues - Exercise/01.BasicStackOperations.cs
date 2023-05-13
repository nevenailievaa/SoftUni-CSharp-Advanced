using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

//INPUT
int[] parameters = Console.ReadLine().Split().Select(int.Parse).ToArray();
int elementsCnt = parameters[0];
int popElementsCnt = parameters[1];
int x = parameters[2];

//ACTION
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

if (numbers.Length == elementsCnt)
{
    Stack<int> stack = new Stack<int>(numbers);

	for (int i = 1; i <= popElementsCnt; i++)
	{
		if (stack.Count > 0)
		{
            stack.Pop();
        }
    }

	if (stack.Count == 0)
	{
        Console.WriteLine(0);
    }
	else if (stack.Contains(x))
	{
		Console.WriteLine("true");
	}
	else
	{
		Console.WriteLine(stack.Min());
	}
}