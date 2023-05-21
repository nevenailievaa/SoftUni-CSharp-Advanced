//INPUT
int userNamesCount = int.Parse(Console.ReadLine());

//ACTION
HashSet<string> userNames = new HashSet<string>();

for (int i = 0; i < userNamesCount; i++)
{
    userNames.Add(Console.ReadLine());
}

//OUTPUT
foreach (var user in userNames)
{
    Console.WriteLine(user);
}