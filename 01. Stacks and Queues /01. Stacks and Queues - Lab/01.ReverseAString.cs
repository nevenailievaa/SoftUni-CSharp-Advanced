//INPUT
string inputString = Console.ReadLine();

//ACTION
Stack<char> stack = new Stack<char>(inputString);

//OUTPUT
for (int i = stack.Count; i > 0; i--)
{
    char currChar = stack.Peek();
    Console.Write(currChar);
    stack.Pop();
}