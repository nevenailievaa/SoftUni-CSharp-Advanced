//INPUT
int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
string snakeName = Console.ReadLine();
int rows = dimensions[0];
int cols = dimensions[1];

//ACTION
char[,] matrix = new char[rows, cols];

//Creating The Snake's Matrix Path
int index = 0;

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        if (row % 2 == 0)
        {
            matrix[row, col] = snakeName[index];
        }
        else
        {
            matrix[row, cols - 1 - col] = snakeName[index];
        }

        index++;

        if (index >= snakeName.Length)
        {
            index = 0;
        }
    }
}

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        Console.Write(matrix[row, col]);
    }
    Console.WriteLine();
}