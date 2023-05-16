using System;
using System.Numerics;

//INPUT
int matrixElementsCount = int.Parse(Console.ReadLine());
int[,] matrix = new int[matrixElementsCount, matrixElementsCount];

//ACTION
for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] matrixElements = Console.ReadLine().Split().Select(int.Parse).ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = matrixElements[col];
    }
}

int sum = 0;
for (int i = 0; i < matrixElementsCount; i++)
{
    sum += matrix[i, i];
}

//OUTPUT
Console.WriteLine(sum);