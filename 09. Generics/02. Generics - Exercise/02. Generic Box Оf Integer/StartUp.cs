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

Console.WriteLine(box.ToString());