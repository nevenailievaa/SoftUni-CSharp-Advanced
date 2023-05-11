//INPUT
int[] inputIntegers = Console.ReadLine().Split().Select(int.Parse).ToArray();

//ACTION
Stack<int> stack = new Stack<int>(inputIntegers);

string command = Console.ReadLine().ToLower();

while (command != "end")
{
	string[] commandArray = command.Split();
	string commandType = commandArray[0].ToLower();

    //Add Command
    if (commandType == "add")
	{
		stack.Push(int.Parse(commandArray[1]));
		stack.Push(int.Parse(commandArray[2]));
    }

    //Remove Command
    else if (commandType == "remove")
	{
		int count = int.Parse(commandArray[1]);

		if (stack.Count >= count)
		{
            for (int i = 0; i < count; i++)
            {
                stack.Pop();
            }
        }
	}

    command = Console.ReadLine().ToLower();
}

//OUTPUT
int sum = 0;
foreach (int num in stack)
{
	sum += num;
}

Console.WriteLine($"Sum: {sum}");