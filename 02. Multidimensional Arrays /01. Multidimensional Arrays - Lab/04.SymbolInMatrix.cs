using System;
using System.Numerics;

//INPUT
int matrixElementsCount = int.Parse(Console.ReadLine());
char[,] matrix = new char[matrixElementsCount, matrixElementsCount];

//ACTION
for (int row = 0; row < matrixElementsCount; row++)
{
    char[] matrixCharElements = Console.ReadLine().ToCharArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = matrixCharElements[col];
    }
}

char symbol = char.Parse(Console.ReadLine());

//Searching The Char
for (int row = 0; row < matrixElementsCount; row++)
{
    for (int col = 0; col < matrixElementsCount; col++)
    {
        if (matrix[row, col] == symbol)
        {
            Console.WriteLine($"({row}, {col})");
            return;
        }
    }
}

//OUTPUT
Console.WriteLine($"{symbol} does not occur in the matrix");