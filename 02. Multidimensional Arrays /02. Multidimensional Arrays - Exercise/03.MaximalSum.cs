using System;
using System.Linq;

//INPUT
int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int rows = dimensions[0];
int cols = dimensions[1];

//ACTION
int[,] matrix = new int[rows, cols];

//Creating The Matrix
for (int row = 0; row < rows; row++)
{
    int[] nums = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = nums[col];
    }
}

//Finding Sums
int biggestSum = int.MinValue;
int bestRow = 0;
int bestCol = 0;

for (int row = 0; row < rows - 2; row++)
{
    for (int col = 0; col < cols - 2; col++)
    {
        int currentSum = matrix[row, col] + matrix[row, col+1] + matrix[row, col+2] +
            matrix[row+1, col] + matrix[row+1, col+1] + matrix[row+1, col+2] +
            matrix[row+2, col] + matrix[row+2, col+1] + matrix[row+2, col+2];

        if (currentSum > biggestSum)
        {
            biggestSum = currentSum;
            bestRow = row;
            bestCol = col;
        }
    }
}

Console.WriteLine($"Sum = {biggestSum}");

for (int row = bestRow; row < bestRow+3; row++)
{
    for (int col = bestCol; col < bestCol+3; col++)
    {
        Console.Write(matrix[row, col] + " ");
    }
    Console.WriteLine();
}