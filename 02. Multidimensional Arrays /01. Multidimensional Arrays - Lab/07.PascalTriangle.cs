using System;

//INPUT
int rowsCount = int.Parse(Console.ReadLine());

//ACTION
long[][] matrix = new long[rowsCount][];

for (int row = 0; row < rowsCount; row++)
{
    long[] numbers = new long[row+1];

	for (int col = 0; col < numbers.Length; col++)
	{
		if (col == 0 || col == numbers.Length-1)
		{
			numbers[col] = 1;
        }
		else
		{
            long firstNum = matrix[row-1][col - 1];
            long secondNum = matrix[row-1][col];
            numbers[col] = firstNum + secondNum;
        }
        matrix[row] = numbers;
    }
}

//OUTPUT
foreach (long[] array in matrix)
{
	Console.WriteLine(String.Join(" ", array));
}