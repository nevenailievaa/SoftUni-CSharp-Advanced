//INPUT
int namesCount = int.Parse(Console.ReadLine());

//ACTION
HashSet<string> names = new HashSet<string>();

for (int i = 0; i < namesCount; i++)
{
    string name = Console.ReadLine();
    names.Add(name);
}

//OUTPUT
foreach (var name in names)
{
    Console.WriteLine(name);
}