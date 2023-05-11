//INPUT
string input = Console.ReadLine();

//ACTION
Stack<int> indexes = new Stack<int>();
List<string> expressions = new List<string>();

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '(')
    {
        indexes.Push(i);
    }
    else if (input[i] == ')')
    {
        int indexOfOpenBracket = indexes.Pop();
        int indexOfClosedBracket = i;

        string currentExpression = input.Substring(indexOfOpenBracket, indexOfClosedBracket - indexOfOpenBracket + 1);

        expressions.Add(currentExpression);
    }
}

//OUTPUT
foreach (var expression in expressions)
{
    Console.WriteLine(expression);
}