//INPUT
int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
string snakeName = Console.ReadLine();
int rows = dimensions[0];
int cols = dimensions[1];

//ACTION
Queue<char> snakeQueue = new Queue<char>(snakeName);

char[,] matrix = new char[rows, cols];

//Creating The Snake's Matrix Path
for (int row = 0; row < rows; row++)
{
    if (row % 2 == 0)
    {
        for (int col = 0; col < cols; col++)
        {
            char currentChar = snakeQueue.Dequeue();
            matrix[row, col] = currentChar;
            snakeQueue.Enqueue(currentChar);
        }
    }
    else
    {
        for (int col = cols-1; col >= 0; col--)
        {
            char currentChar = snakeQueue.Dequeue();
            matrix[row, col] = currentChar;
            snakeQueue.Enqueue(currentChar);
        }
    }
}

//Matrix Output
for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        Console.Write(matrix[row,col]);
    }
    Console.WriteLine();
}
