//INPUT
int[] rowsAndCols = Console.ReadLine()
    .Split(",", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rowsCount = rowsAndCols[0];
int colsCount = rowsAndCols[1];

char[,] cupboard = new char[rowsCount, colsCount];
int mouseRow = 0;
int mouseCol = 0;
int cheeseCount = 0;

for (int row = 0; row < rowsCount; row++)
{
    string rowInfo = Console.ReadLine();

    for (int col = 0; col < colsCount; col++)
    {
        cupboard[row, col] = rowInfo[col];

        if (cupboard[row, col] == 'M')
        {
            mouseRow = row;
            mouseCol = col;
        }
        else if (cupboard[row, col] == 'C')
        {
            cheeseCount++;
        }
    }
}

//ACTION
string command = string.Empty;
int cheeseEaten = 0;

while ((command = Console.ReadLine()) != "danger")
{
    bool moveIsMade = false;

    if (command == "up" && CheckPosition(mouseRow-1, mouseCol, rowsCount, colsCount))
    {
        if (cupboard[mouseRow-1, mouseCol] != '@')
        {
            cupboard[mouseRow, mouseCol] = '*';
            mouseRow--;
            moveIsMade = true;
        }
    }
    else if (command == "down" && CheckPosition(mouseRow+1, mouseCol, rowsCount, colsCount))
    {
        if (cupboard[mouseRow+1, mouseCol] != '@')
        {
            cupboard[mouseRow, mouseCol] = '*';
            mouseRow++;
            moveIsMade = true;
        }
    }
    else if (command == "left" && CheckPosition(mouseRow, mouseCol-1, rowsCount, colsCount))
    {
        if (cupboard[mouseRow, mouseCol-1] != '@')
        {
            cupboard[mouseRow, mouseCol] = '*';
            mouseCol--;
            moveIsMade = true;
        }
    }
    else if (command == "right" && CheckPosition(mouseRow, mouseCol+1, rowsCount, colsCount))
    {
        if (cupboard[mouseRow, mouseCol+1] != '@')
        {
            cupboard[mouseRow, mouseCol] = '*';
            mouseCol++;
            moveIsMade = true;
        }
    }
    else
    {
        Console.WriteLine("No more cheese for tonight!");
        PrintMatrix(cupboard, rowsCount, colsCount);
        return;
    }

    //If Move Is Made
    if (moveIsMade)
    {
        //Cheese
        if (cupboard[mouseRow, mouseCol] == 'C')
        {
            cheeseEaten++;
            if (cheeseCount == cheeseEaten)
            {
                cupboard[mouseRow, mouseCol] = 'M';
                Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                PrintMatrix(cupboard, rowsCount, colsCount);
                return;
            }
        }
        //Trap
        else if (cupboard[mouseRow, mouseCol] == 'T')
        {
            cupboard[mouseRow, mouseCol] = 'M';
            Console.WriteLine("Mouse is trapped!");
            PrintMatrix(cupboard, rowsCount, colsCount);
            return;
        }

        cupboard[mouseRow, mouseCol] = 'M';
    }
}
//OUTPUT
Console.WriteLine("Mouse will come back later!");
PrintMatrix(cupboard, rowsCount, colsCount);


//Valid Index Position Check
static bool CheckPosition(int row, int col, int rowsCount, int colsCount)
{
    if (row >= 0 && row < rowsCount && col >= 0 && col < colsCount)
    {
        return true;
    }
    return false;
}

//Print Matrix
static void PrintMatrix(char[,] matrix, int rowsCount, int colsCount)
{
    for (int row = 0; row < rowsCount; row++)
    {
        for (int col = 0; col < colsCount; col++)
        {
            Console.Write(matrix[row, col]);
        }
        Console.WriteLine();
    }
}