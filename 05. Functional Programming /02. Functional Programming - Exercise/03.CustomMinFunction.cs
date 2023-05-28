//INPUT
Func<string, int[]> readIntegers = input => input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
.Select(int.Parse)
.ToArray();

int[] numbers = readIntegers(Console.ReadLine());

//OUTPUT
Action<int[]> output = numbers => Console.WriteLine(numbers.Min());
output(numbers);