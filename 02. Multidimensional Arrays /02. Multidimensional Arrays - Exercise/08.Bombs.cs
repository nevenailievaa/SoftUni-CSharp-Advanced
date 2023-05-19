//INPUT
int matrixLength = int.Parse(Console.ReadLine());

//ACTION
int[,] matrix = new int[matrixLength, matrixLength];

//Creating The Matrix
for (int row = 0; row < matrixLength; row++)
{
	int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

	for (int col = 0; col < matrixLength; col++)
	{
		matrix[row, col] = numbers[col];
	}
}

string[] coordinates = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

//Bombs Proceeding
for (int i = 0; i < coordinates.Length; i++)
{
    int[] rowAndCol = coordinates[i].Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    int currentRow = rowAndCol[0];
	int currentCol = rowAndCol[1];

	if (matrix[currentRow, currentCol] > 0)
	{
		int bombValue = matrix[currentRow, currentCol];

        //Exploding Range
        matrix[currentRow, currentCol] = 0;

        Exploding(matrix, matrixLength, currentRow, currentCol, bombValue);
    }
}

//OUTPUT
AliveCellsCounting(matrix, matrixLength);
MatrixPrint(matrix, matrixLength);



//Exploding Method
static void Exploding(int[,] matrix, int matrixLength, int currentRow, int currentCol, int bombValue)
{
    //Up And Current Row
    if (currentRow - 1 >= 0)
    {
        if (currentCol - 1 >= 0)
        {
            if (AliveCellChecker(matrix, currentRow-1, currentCol-1))
            {
                matrix[currentRow-1, currentCol-1] -= bombValue;
            }
        }

        if (AliveCellChecker(matrix, currentRow-1, currentCol))
        {
            matrix[currentRow-1, currentCol] -= bombValue;
        }

        if (currentCol + 1 < matrixLength)
        {
            if (AliveCellChecker(matrix, currentRow-1, currentCol+1))
            {
                matrix[currentRow-1, currentCol+1] -= bombValue;
            }
        }
    }

    //Current Row
    if (currentCol - 1 >= 0)
    {
        if (AliveCellChecker(matrix, currentRow, currentCol-1))
        {
            matrix[currentRow, currentCol-1] -= bombValue;
        }
    }
    if (currentCol + 1 < matrixLength)
    {
        if (AliveCellChecker(matrix, currentRow, currentCol+1))
        {
            matrix[currentRow, currentCol+1] -= bombValue;
        }
    }

    //Down Row
    if (currentRow + 1 < matrixLength)
    {
        if (currentCol - 1 >= 0)
        {
            if (AliveCellChecker(matrix, currentRow+1, currentCol-1))
            {
                 matrix[currentRow+1, currentCol-1] -= bombValue;
            }
        }

        if (AliveCellChecker(matrix, currentRow+1, currentCol))
        {
            matrix[currentRow+1, currentCol] -= bombValue;
        }
        

        if (currentCol + 1 < matrixLength)
        {
            if (AliveCellChecker(matrix, currentRow+1, currentCol+1))
            {
                matrix[currentRow+1, currentCol+1] -= bombValue;
            }
        }
    }
}



//Alive Cell Checker
static bool AliveCellChecker(int[,] matrix, int currentRow, int currentCol)
{
    if (matrix[currentRow,currentCol] > 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}



//Alive Cells Counting Method
static void AliveCellsCounting(int[,] matrix, int matrixLength)
{
    int aliveCellsCount = 0;
    int aliveCellsSum = 0;

    for (int row = 0; row < matrixLength; row++)
    {
        for (int col = 0; col < matrixLength; col++)
        {
            if (matrix[row, col] > 0)
            {
                aliveCellsCount++;
                aliveCellsSum += matrix[row, col];
            }
        }
    }

    Console.WriteLine($"Alive cells: {aliveCellsCount}");
    Console.WriteLine($"Sum: {aliveCellsSum}");
}



//Matrix Print Method
static void MatrixPrint(int[,] matrix, int matrixLength)
{
    for (int row = 0; row < matrixLength; row++)
    {
        for (int col = 0; col < matrixLength; col++)
        {
            Console.Write(matrix[row, col] + " ");
        }
        Console.WriteLine();
    }
}
