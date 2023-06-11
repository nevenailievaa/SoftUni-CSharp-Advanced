using CustomStack;
using System.Timers;

//INPUT
string[] input = Console.ReadLine()
    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Skip(1)
    .ToArray();

CustomStack<string> stack = new CustomStack<string>();

foreach (var element in input)
{
    stack.Push(element);
}

string command = string.Empty;
while ((command = Console.ReadLine()) != "END")
{
    if (command == "Pop")
    {
        if (stack.Counter <= 0)
        {
            Console.WriteLine("No elements");
            continue;
        }
        stack.Pop();
    }
    else if (command.Contains("Push"))
    {
        string[] commandArray = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
        stack.Push(commandArray[1]);
    }
}

foreach (var item in stack)
{
    Console.WriteLine(item);
}
foreach (var item in stack)
{
    Console.WriteLine(item);
}