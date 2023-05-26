//INPUT
int[] integers = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .Where(n => n % 2 == 0)
    .OrderBy(n => n)
    .ToArray();

//OUTPUT
Console.WriteLine(String.Join(", ", integers));