//INPUT
int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int rows = dimensions[0];
int cols = dimensions[1];

string[,] playGround = new string[rows,cols];
int playerRow = 0;
int playerCol = 0;

for (int row = 0; row < rows; row++)
{
    string[] playgroundInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

    for (int col = 0; col < cols; col++)
    {
        playGround[row, col] = playgroundInfo[col];

        if (playgroundInfo[col] == "B")
        {
            playerRow = row;
            playerCol = col;
        }
    }
}

//ACTION
int touchedOpponents = 0;
int movesMade = 0;
string command = string.Empty;

while ((command = Console.ReadLine()) != "Finish")
{
    //Validity Checker
    if (command == "up")
    {
        if (playerRow - 1 >= 0 && playGround[playerRow-1, playerCol] != "O")
        {
            playerRow--;
            movesMade++;
        }
    }
    else if (command == "down")
    {
        if (playerRow + 1 < rows && playGround[playerRow+1, playerCol] != "O")
        {
            playerRow++;
            movesMade++;
        }
    }
    else if (command == "left")
    {
        if (playerCol - 1 >= 0 && playGround[playerRow, playerCol-1] != "O")
        {
            playerCol--;
            movesMade++;
        }
    }
    else if (command == "right")
    {
        if (playerCol + 1 < cols && playGround[playerRow, playerCol+1] != "O")
        {
            playerCol++;
            movesMade++;
        }
    }

    //Touched Player Checker
    if (playGround[playerRow,playerCol] == "P")
    {
        touchedOpponents++;
        playGround[playerRow, playerCol] = "-";
    }

    if (touchedOpponents == 3)
    {
        break;
    }
}

//OUTPUT
Console.WriteLine("Game over!");
Console.WriteLine($"Touched opponents: {touchedOpponents} Moves made: {movesMade}");