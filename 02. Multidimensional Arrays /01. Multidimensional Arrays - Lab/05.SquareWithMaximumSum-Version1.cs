using System;
using System.Collections.Concurrent;
using System.Numerics;
using System.Runtime.Serialization.Formatters;

//INPUT
int[] matrixElementsCount = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rows = matrixElementsCount[0];
int cols = matrixElementsCount[1];
int[,] matrix = new int[rows, cols];

//ACTION
for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] matrixElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = matrixElements[col];
    }
}

int biggestSum = int.MinValue;
int currentSum = 0;

List<int> indexes = new List<int>();

for (int row = 0; row < rows-1; row++)
{
    for (int col = 0; col < cols-1; col++)
    {
        currentSum += matrix[row, col] + matrix[row, col+1] + matrix[row+1, col] + matrix[row+1, col+1];

        if (currentSum > biggestSum)
        {
            indexes.Clear();
            indexes.Add(matrix[row, col]);
            indexes.Add(matrix[row, col+1]);
            indexes.Add(matrix[row+1, col]);
            indexes.Add(matrix[row+1, col+1]);

            biggestSum = currentSum;
        }
        currentSum = 0;
    }
}

//OUTPUT
Console.WriteLine($"{indexes[0]} {indexes[1]}");
Console.WriteLine($"{indexes[2]} {indexes[3]}");
Console.WriteLine(biggestSum);
