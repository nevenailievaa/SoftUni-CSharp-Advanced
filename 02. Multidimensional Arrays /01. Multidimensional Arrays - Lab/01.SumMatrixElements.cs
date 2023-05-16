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
    int[] matrixElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
	{
        matrix[row, col] = matrixElements[col];
    }
}

int sumElements = 0;
foreach (var item in matrix)
{
    sumElements += item;
}

//OUTPUT
Console.WriteLine(matrix.GetLength(0));
Console.WriteLine(matrix.GetLength(1));
Console.WriteLine(sumElements);