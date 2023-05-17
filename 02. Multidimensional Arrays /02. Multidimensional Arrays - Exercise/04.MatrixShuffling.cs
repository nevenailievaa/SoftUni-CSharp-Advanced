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
    int[] symbols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = symbols[col];
    }
}

//Commands
string command = string.Empty;

while ((command = Console.ReadLine()) != "END")
{
    string[] commandArray = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    string typeCommand = commandArray[0];

    if (typeCommand == "swap" && commandArray.Length == 5)
    {
        int rowOne = int.Parse(commandArray[1]);
        int colOne = int.Parse(commandArray[2]);
        int rowTwo = int.Parse(commandArray[3]);
        int colTwo = int.Parse(commandArray[4]);

        if (rowOne < rows && rowTwo < rows && colOne < cols && colTwo < cols &&
            rowOne >= 0 && rowTwo >= 0 && colOne >= 0 && colTwo >= 0)
        {
            int thirdVariable = matrix[rowOne, colOne];
            matrix[rowOne, colOne] = matrix[rowTwo, colTwo];
            matrix[rowTwo, colTwo] = thirdVariable;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
    else
    {
        Console.WriteLine("Invalid input!");
    }
}
