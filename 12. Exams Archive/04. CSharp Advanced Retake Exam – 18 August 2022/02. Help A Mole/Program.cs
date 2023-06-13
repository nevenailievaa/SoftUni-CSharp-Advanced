using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace _02.HelpAMole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int fieldSize = int.Parse(Console.ReadLine());
            char[,] field = new char[fieldSize, fieldSize];
            int moleRow = 0;
            int moleCol = 0;

            int locOneRow = -1;
            int locOneCol = -1;
            int locTwoRow = -1;
            int locTwoCol = -1;

            for (int row = 0; row < fieldSize; row++)
            {
                string rowInfo = Console.ReadLine();

                for (int col = 0; col < fieldSize; col++)
                {
                    field[row, col] = rowInfo[col];

                    if (rowInfo[col] == 'M')
                    {
                        moleRow = row;
                        moleCol = col;
                    }
                    if (rowInfo[col] == 'S')
                    {
                        if (locOneRow >= 0)
                        {
                            locTwoRow = row;
                            locTwoCol = col;
                        }
                        else
                        {
                            locOneRow = row;
                            locOneCol = col;
                        }
                    }
                }
            }

            //ACTION
            int points = 0;
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                if (command == "up" && CheckIndex(fieldSize, moleRow-1, moleCol))
                {
                    field[moleRow, moleCol] = '-';
                    moleRow -= 1;
                }
                else if (command == "down" && CheckIndex(fieldSize, moleRow+1, moleCol))
                {
                    field[moleRow, moleCol] = '-';
                    moleRow += 1;
                }
                else if (command == "left" && CheckIndex(fieldSize, moleRow, moleCol-1))
                {
                    field[moleRow, moleCol] = '-';
                    moleCol -= 1;
                }
                else if (command == "right" && CheckIndex(fieldSize, moleRow, moleCol+1))
                {
                    field[moleRow, moleCol] = '-';
                    moleCol += 1;
                }

                //Points Check
                if (char.IsDigit(field[moleRow, moleCol]))
                {
                    points += int.Parse(field[moleRow, moleCol].ToString());

                    if (points >= 25)
                    {
                        field[moleRow, moleCol] = 'M';
                        break;
                    }
                }

                //Special Location Teleportation
                else if (field[moleRow, moleCol] == 'S')
                {
                    if (moleRow == locOneRow && moleCol == locOneCol)
                    {
                        moleRow = locTwoRow;
                        moleCol = locTwoCol;
                        field[locOneRow, locOneCol] = '-';

                    }
                    else if (moleRow == locTwoRow && moleCol == locTwoCol)
                    {
                        moleRow = locOneRow;
                        moleCol = locOneCol;
                        field[locTwoRow, locTwoCol] = '-';
                    }
                    points -= 3;
                }
                field[moleRow, moleCol] = 'M';
            }
            
            //OUTPUT
            if (points >= 25)
            {
                Console.WriteLine("Yay! The Mole survived another game!");
                Console.WriteLine($"The Mole managed to survive with a total of {points} points.");
            }
            else
            {
                Console.WriteLine("Too bad! The Mole lost this battle!");
                Console.WriteLine($"The Mole lost the game with a total of {points} points.");
            }
            
            //Field Print
            for (int row = 0; row < fieldSize; row++)
            {
                for (int col = 0; col < fieldSize; col++)
                {
                    Console.Write(field[row,col]);
                }
                Console.WriteLine();
            }

            //Check Index Method
            static bool CheckIndex(int fieldSize, int row, int col)
            {
                if (row >= 0 && row < fieldSize && col >= 0 && col < fieldSize)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Don't try to escape the playing field!");
                    return false;
                }
            }
        }
    }
}
