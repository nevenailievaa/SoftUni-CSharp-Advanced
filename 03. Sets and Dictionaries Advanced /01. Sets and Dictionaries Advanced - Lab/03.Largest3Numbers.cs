//INPUT
using System.Collections.Immutable;

int[] integers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .OrderByDescending(n => n)
    .ToArray();

//OUTPUT
if (integers.Length >= 3)
{
    for (int i = 0; i < 3; i++)
    {
        if (i < 2)
        {
            Console.Write(integers[i] + " ");
        }
        else
        {
            Console.Write(integers[i]);
        }
    }
}
else
{
    for (int i = 0; i < integers.Length; i++)
    {
        if (i < integers.Length-1)
        {
            Console.Write(integers[i] + " ");
        }
        else
        {
            Console.Write(integers[i]);
        }
    }
}