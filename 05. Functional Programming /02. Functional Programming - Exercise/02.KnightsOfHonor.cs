//INPUT
Func<string, string[]> readingNames = names => names.Split(" ", StringSplitOptions.RemoveEmptyEntries)
.Select(name => "Sir" + " " + name)
.ToArray();
string[] words = readingNames(Console.ReadLine());

//OUTPUT
Action<string[]> printer = names => Console.WriteLine(string.Join("\n", names));
printer(words);