//INPUT
using System.Data;

int fieldSize = int.Parse(Console.ReadLine());
string[] moves = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
int hazelnutsCount = 0;

//ACTION
string[,] field = new string[fieldSize, fieldSize];
int squirrelRow = 0;
int squirrelCol = 0;

for (int row = 0; row < fieldSize; row++)
{
    string fieldInfo = Console.ReadLine();

    for (int col = 0; col < fieldSize; col++)
	{
        field[row, col] = fieldInfo[col].ToString();

		if (field[row,col] == "s")
		{
            squirrelRow = row;
            squirrelCol = col;
        }
	}
}

for (int i = 0; i < moves.Length; i++)
{
    if (moves[i] == "up")
    {
        if (IndexCheck(fieldSize, squirrelRow-1, squirrelCol))
        {
            squirrelRow -= 1;
        }
        else
        {
            Console.WriteLine("The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {hazelnutsCount}");
            return;
        }
    }
    else if (moves[i] == "down")
    {
        if (IndexCheck(fieldSize, squirrelRow+1, squirrelCol))
        {
            squirrelRow += 1;
        }
        else
        {
            Console.WriteLine("The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {hazelnutsCount}");
            return;
        }
    }
    else if (moves[i] == "left")
    {
        if (IndexCheck(fieldSize, squirrelRow, squirrelCol-1))
        {
            squirrelCol -= 1;
        }
        else
        {
            Console.WriteLine("The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {hazelnutsCount}");
            return;
        }
    }
    else if (moves[i] == "right")
    {
        if (IndexCheck(fieldSize, squirrelRow, squirrelCol+1))
        {
            squirrelCol += 1;
        }
        else
        {
            Console.WriteLine("The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {hazelnutsCount}");
            return;
        }
    }

    //Hazelnut Check
    if (field[squirrelRow, squirrelCol] == "h")
    {
        hazelnutsCount++;
        field[squirrelRow, squirrelCol] = "*";
    }
    //Trap Check
    else if (field[squirrelRow, squirrelCol] == "t")
    {
        Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
        Console.WriteLine($"Hazelnuts collected: {hazelnutsCount}");
        return;
    }
    //Hazelnuts  Sum Check
    if (hazelnutsCount == 3)
    {
        Console.WriteLine("Good job! You have collected all hazelnuts!");
        Console.WriteLine($"Hazelnuts collected: {hazelnutsCount}");
        return;
    }
}
//OUTPUT
Console.WriteLine("There are more hazelnuts to collect.");
Console.WriteLine($"Hazelnuts collected: {hazelnutsCount}");

//Methods
static bool IndexCheck(int fieldSize, int row , int col)
{
    if (row >= 0 && row < fieldSize && col >= 0 && col < fieldSize)
    {
        return true;
    }
    return false;
}