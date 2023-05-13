using System;
using System.Collections.Generic;
using System.Linq;

//INPUT
int queriesCnt = int.Parse(Console.ReadLine());

//ACTION
Stack<int> numbers = new Stack<int>();

for (int i = 1; i <= queriesCnt; i++)
{
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

	if (input[0] == 1)
	{
        numbers.Push(input[1]);
	}
	else if (input[0] == 2)
	{
        numbers.Pop();
	}
    else if (input[0] == 3)
    {
        if (numbers.Count > 0)
        {
            Console.WriteLine(numbers.Max());
        }
    }
    else if (input[0] == 4)
    {
        if (numbers.Count > 0)
        {
            Console.WriteLine(numbers.Min());
        }
    }
}

//OUTPUT
Console.WriteLine(String.Join(", ", numbers));