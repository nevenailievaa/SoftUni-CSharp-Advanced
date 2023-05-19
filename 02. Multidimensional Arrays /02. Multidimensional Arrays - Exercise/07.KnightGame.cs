//INPUT
int size = int.Parse(Console.ReadLine());

//ACTION
if (size < 3)
{
    Console.WriteLine(0);
    return;
}

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

int knightsRemoved = 0;

while(true)
{
    int countMostAttacking = 0;
    int rowMostAttacking = 0;
    int colMostAttacking = 0;

    for (int row = 0; row < size; row++)
    {
        for (int col = 0; col < size; col++)
        {
            if (chessBoard[row,col] == 'K')
            {
                int attackedKnights = CountAttackedKnights(row, col, size, chessBoard);

                if (countMostAttacking < attackedKnights)
                {
                    countMostAttacking = attackedKnights;
                    rowMostAttacking = row;
                    colMostAttacking = col;
                }
            }
        }
    }
    if (countMostAttacking == 0)
    {
        break;
    }
    else
    {
        chessBoard[rowMostAttacking, colMostAttacking] = '0';
        knightsRemoved++;
    }
}

//OUTPUT
Console.WriteLine(knightsRemoved);

//Attacked Knights Counter
static int CountAttackedKnights(int row, int col, int size, char[,] matrix)
{
    int attackedKnights = 0;

    //Horizontal Left - Up
    if (IsCellValid(row-1, col-2, size))
    {
        if (matrix[row-1, col-2] == 'K')
        {
            attackedKnights++;
        }
    }
    //Horizontal Left - Down
    if (IsCellValid(row+1, col-2, size))
    {
        if (matrix[row+1, col-2] == 'K')
        {
            attackedKnights++;
        }
    }
    //Horizontal Right - Up
    if (IsCellValid(row-1, col+2, size))
    {
        if (matrix[row-1, col+2] == 'K')
        {
            attackedKnights++;
        }
    }
    //Horizontal Right - Down
    if (IsCellValid(row+1, col+2, size))
    {
        if (matrix[row+1, col+2] == 'K')
        {
            attackedKnights++;
        }
    }

    //Up-Left
    if (IsCellValid(row-2, col-1, size))
    {
        if (matrix[row-2, col-1] == 'K')
        {
            attackedKnights++;
        }
    }
    //Up-Right
    if (IsCellValid(row-2, col+1, size))
    {
        if (matrix[row-2, col+1] == 'K')
        {
            attackedKnights++;
        }
    }
    //Down-Left
    if (IsCellValid(row+2, col-1, size))
    {
        if (matrix[row+2, col-1] == 'K')
        {
            attackedKnights++;
        }
    }
    //Down-Right
    if (IsCellValid(row+2, col+1, size))
    {
        if (matrix[row+2, col+1] == 'K')
        {
            attackedKnights++;
        }
    }

    return attackedKnights;
}

//Valid Cell Checker
static bool IsCellValid(int row, int col, int size)
{
    return row >= 0 && row < size && col >= 0 && col < size;
}
