using Tuple;

//INPUT
string[] nameAndAdressInfo = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

string[] nameAndBeerInfo = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

string[] numbersInfo = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

//ACTION
CustomTuple<string, string> nameAndAdress =
    new CustomTuple<string, string>($"{nameAndAdressInfo[0]} {nameAndAdressInfo[1]}", nameAndAdressInfo[2]);

CustomTuple<string, int> nameAndBeer =
    new CustomTuple<string, int>(nameAndBeerInfo[0], int.Parse(nameAndBeerInfo[1]));

CustomTuple<int, double> numbers =
    new CustomTuple<int, double>(int.Parse(numbersInfo[0]), double.Parse(numbersInfo[1]));

//OUTPUT
Console.WriteLine(nameAndAdress.ToString());
Console.WriteLine(nameAndBeer.ToString());
Console.WriteLine(numbers.ToString());

