using System;

//INPUT
int matrixSize = int.Parse(Console.ReadLine());

//ACTION
int[,] matrix = new int[matrixSize, matrixSize];

//Creating The Matrix
for (int row = 0; row < matrixSize; row++)
{
    int[] currentNums = Console.ReadLine().Split().Select(int.Parse).ToArray();

    for (int col = 0; col < matrixSize; col++)
    {
        matrix[row, col] = currentNums[col];
    }
}

//Diagonals Sum
int firstDiagonalSum = 0;
int secondDiagonalSum = 0;

for (int rowAndCol = 0; rowAndCol < matrixSize; rowAndCol++)
{
    firstDiagonalSum += matrix[rowAndCol, rowAndCol];
    secondDiagonalSum += matrix[rowAndCol, matrixSize-rowAndCol-1];
}

//OUTPUT
Console.WriteLine(Math.Abs(firstDiagonalSum - secondDiagonalSum));