using System;
using GenericBoxОfString;

//INPUT
int count = int.Parse(Console.ReadLine());

//ACTION
Box<int> box = new Box<int>();

for (int i = 0; i < count; i++)
{
    int item = int.Parse(Console.ReadLine());

    box.Add(item);
}

int[] indexes = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

box.Swap(indexes[0], indexes[1]);
Console.WriteLine(box.ToString());