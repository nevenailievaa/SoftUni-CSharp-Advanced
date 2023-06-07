using System;
using GenericBoxОfString;

//INPUT
int count = int.Parse(Console.ReadLine());

//ACTION
Box<double> box = new Box<double>();

for (int i = 0; i < count; i++)
{
    double item = double.Parse(Console.ReadLine());

    box.Add(item);
}

double itemToCompare = double.Parse(Console.ReadLine());

Console.WriteLine(box.Compare(itemToCompare));