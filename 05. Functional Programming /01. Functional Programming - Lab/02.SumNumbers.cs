Func<string, int> parser = n => int.Parse(n);

int[] numbers = Console.ReadLine().Split(", ").Select(parser).ToArray();

Console.WriteLine(numbers.Length);
Console.WriteLine(numbers.Sum());