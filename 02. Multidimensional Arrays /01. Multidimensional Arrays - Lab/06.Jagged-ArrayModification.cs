using System;
using System.Reflection;

//INPUT
int matrixRows = int.Parse(Console.ReadLine());

//ACTION
int[][] matrix = new int[matrixRows][];

for (int i = 0; i < matrixRows; i++)
{
    matrix[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
}

string command = string.Empty;
while ((command = Console.ReadLine()) != "END")
{
	string[] commandArray = command.Split().ToArray();

	string commandType = commandArray[0];
    int row = int.Parse(commandArray[1]);
    int col = int.Parse(commandArray[2]);
    int value = int.Parse(commandArray[3]);

    if (matrix.Length > row && row >= 0 && matrix[row].Length > col && col >= 0)
    {
        if (commandType == "Add")
        {
            matrix[row][col] += value;
        }
        else if (commandType == "Subtract")
        {
            matrix[row][col] -= value;
        }
    }
    else
    {
        Console.WriteLine("Invalid coordinates");
    }
}

//OUTPUT
foreach (int[] array in matrix)
{
    Console.WriteLine(string.Join(" ", array));
}