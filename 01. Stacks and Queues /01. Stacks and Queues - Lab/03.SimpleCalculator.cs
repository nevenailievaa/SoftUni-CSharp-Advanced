//INPUT
string[] input = Console.ReadLine().Split().ToArray();

//ACTION
Stack<string> expression = new Stack<string>(input.Reverse());

int result = int.Parse(expression.Pop());

while (expression.Count >= 2)
{
    string sign = expression.Pop();
    int number = int.Parse(expression.Pop());

    if (sign == "+")
    {
        result += number;
    }
    else if (sign == "-")
    {
        result -= number;
    }
}

//OUTPUT
Console.WriteLine(result);