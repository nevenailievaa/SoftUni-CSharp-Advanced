using System;
using GenericBoxОfString;

//INPUT
int count = int.Parse(Console.ReadLine());

//ACTION
Box<string> box = new Box<string>();

for (int i = 0; i < count; i++)
{
    string item = Console.ReadLine();

    box.Add(item);
}

Console.WriteLine(box.ToString());