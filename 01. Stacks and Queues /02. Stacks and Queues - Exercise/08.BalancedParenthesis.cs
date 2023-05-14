using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

//INPUT
char[] paranthesis = Console.ReadLine().ToCharArray(); //{[()]}
Stack<char> paranthesisStack = new Stack<char>();

//ACTION
bool isValid = false;

for (int i = 0; i < paranthesis.Length; i++)
{
    if (paranthesisStack.Count == 0)
    {
        if (paranthesis[i] == '}' || paranthesis[i] == ']' || paranthesis[i] == ')')
        {
            isValid = false;
            break;
        }
    }

	if (paranthesis[i] == '{' || paranthesis[i] == '[' || paranthesis[i] == '(')
	{
        paranthesisStack.Push(paranthesis[i]);
    }
    else if (paranthesis[i] == '}')
    {
        if (paranthesisStack.Peek() == '{')
        {
            paranthesisStack.Pop();
            isValid = true;
        }
        else
        {
            isValid = false;
            break;
        }
    }
    else if (paranthesis[i] == ']')
    {
        if (paranthesisStack.Peek() == '[')
        {
            paranthesisStack.Pop();
            isValid = true;
        }
        else
        {
            isValid = false;
            break;
        }
    }
    else if (paranthesis[i] == ')')
    {
        if (paranthesisStack.Peek() == '(')
        {
            paranthesisStack.Pop();
            isValid = true;
        }
        else
        {
            isValid = false;
            break;
        }
    }
}

//OUTPUT
if (isValid)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}