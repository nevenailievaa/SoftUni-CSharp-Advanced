//INPUT
int size = int.Parse(Console.ReadLine());

//ACTION
char[,] chessBoard = new char[size, size];

//Creating The Chess Board (The Matrix)
for (int row = 0; row < size; row++)
{
    string chars = Console.ReadLine();

    for (int col = 0; col < size; col++)
    {
        chessBoard[row, col] = chars[col];
    }
}

int currentKills = 0;
int bestKills = 0;
int minimumKills = 0;
int bestRow = 0;
int bestCol = 0;

while (true)
{
    for (int row = 0; row < size; row++)
    {
        for (int col = 0; col < size; col++)
        {
            currentKills = CurrentKnightKills(chessBoard, row, col, size);

            if (currentKills > bestKills)
            {
                bestKills = currentKills;
                bestRow = row;
                bestCol = col;
            }
            currentKills = 0;
        }
    }

    if (bestKills > 0)
    {
        chessBoard[bestRow, bestCol] = '0';
        minimumKills++;
        bestKills = 0;
    }
    else
    {
        //OUTPUT
        Console.WriteLine(minimumKills);
        return;
    }
}


//Current Knight Kill Counter
static int CurrentKnightKills(char[,]chessBoard, int row, int col, int size)
{
    int kills = 0;
    //If Current Char Is Knight (K)
    if (chessBoard[row, col] == 'K')
    {
        //Upper Left Move
        if (isValid(row-2, col-1, size))
        {
            if (chessBoard[row-2, col-1] == 'K')
            {
                kills++;
            }
        }

        //Upper Right Move
        if (isValid(row-2, col+1, size))
        {
            if (chessBoard[row-2, col+1] == 'K')
            {
                kills++;
            }
        }

        //Horizontal Right Up Move
        if (isValid(row-1, col+2, size))
        {
            if (chessBoard[row-1, col+2] == 'K')
            {
                kills++;
            }
        }

        //Horizontal Right Down Move
        if (isValid(row+1, col+2, size))
        {
            if (chessBoard[row+1, col+2] == 'K')
            {
                kills++;
            }
        }

        //Horizontal Left Up Move
        if (isValid(row-1, col-2, size))
        {
            if (chessBoard[row-1, col-2] == 'K')
            {
                kills++;
            }
        }

        //Horizontal Left Down Move
        if (isValid(row+1, col-2, size))
        {
            if (chessBoard[row+1, col-2] == 'K')
            {
                kills++;
            }
        }

        //Down Left Move
        if (isValid(row+2, col-1, size))
        {
            if (chessBoard[row+2, col-1] == 'K')
            {
                kills++;
            }
        }

        //Down Right Move
        if (isValid(row+2, col+1, size))
        {
            if (chessBoard[row+2, col+1] == 'K')
            {
                kills++;
            }
        }
    }
    return kills;
}


//Valid Coordinates Checker
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
