using System;
using System.Numerics;

//INPUT
int[] matrixElementsCount = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rows = matrixElementsCount[0];
int cols = matrixElementsCount[1];
int[,] matrix = new int[rows, cols];

//ACTION
for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] matrixElements = Console.ReadLine().Split().Select(int.Parse).ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = matrixElements[col];
    }
}

for (int col = 0; col < matrix.GetLength(1); col++)
{
    int sumCurrentColumn = 0;

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        sumCurrentColumn += matrix[row, col];
    }

    Console.WriteLine(sumCurrentColumn);
}
