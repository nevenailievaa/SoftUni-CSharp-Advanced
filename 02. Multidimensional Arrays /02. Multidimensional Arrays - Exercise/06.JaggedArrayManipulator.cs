using System;

//INPUT
int rows = int.Parse(Console.ReadLine());

//ACTION
int[][] matrix = new int[rows][];

for (int row = 0; row < rows; row++)
{
    int[] currentRowArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    matrix[row] = currentRowArray;
}

//Analyzing The Matrix
for (int row = 1; row < rows; row++)
{
    int[] previousRowArray = matrix[row-1];
    int[] currentRowArray = matrix[row];

    if (currentRowArray.Length == previousRowArray.Length)
    {
        for (int col = 0; col < currentRowArray.Length; col++)
        {
            matrix[row-1][col] *= 2;
            matrix[row][col] *= 2;
        }
    }
    else
    {
        for (int col = 0; col < currentRowArray.Length; col++)
        {
            matrix[row][col] /= 2;
        }
        for (int col = 0; col < previousRowArray.Length; col++)
        {
            matrix[row-1][col] /= 2;
        }
    }
}

//Commands
string command = string.Empty;

while ((command = Console.ReadLine()) != "End")
{
    string[] commandArray = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

    string typeCommand = commandArray[0];
    int row = int.Parse(commandArray[1]);
    int col = int.Parse(commandArray[2]);
    int value = int.Parse(commandArray[3]);

    //Checking The Coordinates
    if (row >= 0 && row < rows && col >= 0 && col < matrix[row].Length)
    {
        //Add Command
        if (typeCommand == "Add")
        {
            matrix[row][col] += value;
        }

        //Subtract Command
        else if (typeCommand == "Subtract")
        {
            matrix[row][col] -= value;
        }
    }
}

//OUTPUT
for (int row = 0; row < rows; row++)
{
    int[] currentRowArray = matrix[row];

    for (int col = 0; col < currentRowArray.Length; col++)
    {
        Console.Write(matrix[row][col] + " ");
    }
    Console.WriteLine();
}