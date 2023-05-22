//INPUT
int size = int.Parse(Console.ReadLine());
string[] moves = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

//ACTION
string[,] field = new string[size, size];

//Creating The Field And Searching The Start And The Coals
int currentRow = 0;
int currentCol = 0;
int coals = 0;

for (int row = 0; row < size; row++)
{
    string[] currentRowArray = Console.ReadLine().Split();

	for (int col = 0; col < size; col++)
	{
        field[row, col] = currentRowArray[col];

        if (currentRowArray[col] == "s")
        {
            currentRow = row;
            currentCol = col;
        }
        else if (currentRowArray[col] == "c")
        {
            coals++;
        }
    }
}

//Miner Moving
for (int i = 0; i < moves.Length; i++)
{
    //Up
    if (moves[i] == "up")
    {
        if (isValid(currentRow-1, currentCol, size))
        {
            currentRow--;
        }
    }

    //Down
    else if (moves[i] == "down")
    {
        if (isValid(currentRow+1, currentCol, size))
        {
            currentRow++;
        }
    }

    //Left
    else if (moves[i] == "left")
    {
        if (isValid(currentRow, currentCol-1, size))
        {
            currentCol--;
        }
    }

    //Right
    else if (moves[i] == "right")
    {
        if (isValid(currentRow, currentCol+1, size))
        {
            currentCol++;
        }
    }

    //If Coal Is Found
    if (field[currentRow, currentCol] == "c")
    {
        coals--;
        field[currentRow, currentCol] = "*";

        if (coals == 0)
        {
            Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
            return;
        }
    }
    //If Current Index Is Game Stop (e)
    else if (field[currentRow, currentCol] == "e")
    {
        Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
        return;
    }
}

//OUTPUT
Console.WriteLine($"{coals} coals left. ({currentRow}, {currentCol})");

//Valid Index Checker
static bool isValid(int row, int col, int size)
{
    if (row >= 0 && row < size && col >= 0 && col < size)
    {
        return true;
    }
    else
    {
        return false;
    }
}