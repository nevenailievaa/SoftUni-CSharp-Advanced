//INPUT
Func<string, string[]> readingStrings = words => words.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
string[] words = readingStrings(Console.ReadLine());

//OUTPUT
Action<string[]> printer = words => Console.WriteLine(string.Join("\n", words));
printer(words);