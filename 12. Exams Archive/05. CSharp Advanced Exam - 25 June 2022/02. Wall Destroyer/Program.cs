using System;
using System.Security.Cryptography.X509Certificates;

namespace _02.WallDestroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int wallSize = int.Parse(Console.ReadLine());
            char[,] wall = new char[wallSize, wallSize];
            int currRow = 0;
            int currCol = 0;

            for (int row = 0; row < wallSize; row++)
            {
                string rowInfo = Console.ReadLine();

                for (int col = 0; col < wallSize; col++)
                {
                    wall[row, col] = rowInfo[col];

                    if (wall[row, col] == 'V')
                    {
                        currRow = row;
                        currCol = col;
                    }
                }
            }

            //ACTION
            int holesMade = 0;
            int rodsHit = 0;
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                //UP
                if (command == "up" && IndexCheck(wallSize, currRow-1, currCol))
                {
                    if (!RodCheck(wall, currRow-1, currCol))
                    {
                        if (!HoleCheck(wall, currRow-1, currCol))
                        {
                            holesMade++;
                        }
                        else
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{currRow-1}, {currCol}]!");
                        }
                        wall[currRow, currCol] = '*';
                        currRow -= 1;
                    }
                    else
                    {
                        rodsHit++;
                        Console.WriteLine("Vanko hit a rod!");
                    }
                }

                //DOWN
                else if (command == "down" && IndexCheck(wallSize, currRow+1, currCol))
                {
                    if (!RodCheck(wall, currRow+1, currCol))
                    {
                        if (!HoleCheck(wall, currRow+1, currCol))
                        {
                            holesMade++;
                        }
                        else
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{currRow+1}, {currCol}]!");
                        }
                        wall[currRow, currCol] = '*';
                        currRow += 1;
                    }
                    else
                    {
                        rodsHit++;
                        Console.WriteLine("Vanko hit a rod!");
                    }
                }

                //LEFT
                else if (command == "left" && IndexCheck(wallSize, currRow, currCol-1))
                {
                    if (!RodCheck(wall, currRow, currCol-1))
                    {
                        if (!HoleCheck(wall, currRow, currCol-1))
                        {
                            holesMade++;
                        }
                        else
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{currRow}, {currCol-1}]!");
                        }
                        wall[currRow, currCol] = '*';
                        currCol -= 1;
                    }
                    else
                    {
                        rodsHit++;
                        Console.WriteLine("Vanko hit a rod!");
                    }
                }

                //RIGHT
                else if (command == "right" && IndexCheck(wallSize, currRow, currCol+1))
                {
                    if (!RodCheck(wall, currRow, currCol+1))
                    {
                        if (!HoleCheck(wall, currRow, currCol+1))
                        {
                            holesMade++;
                        }
                        else
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{currRow}, {currCol+1}]!");
                        }
                        wall[currRow, currCol] = '*';
                        currCol += 1;
                    }
                    else
                    {
                        rodsHit++;
                        Console.WriteLine("Vanko hit a rod!");
                    }
                }

                if (wall[currRow, currCol] == 'C')
                {
                    wall[currRow, currCol] = 'E';
                    holesMade++;
                    break;
                }
            }

            //OUTPUT
            if (wall[currRow, currCol] != 'E')
            {
                wall[currRow, currCol] = 'V';
                holesMade++;
                Console.WriteLine($"Vanko managed to make {holesMade} hole(s) and he hit only {rodsHit} rod(s).");
            }
            else
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {holesMade} hole(s).");
            }

            //Matrix (Wall) Print
            for (int row = 0; row < wallSize; row++)
            {
                for (int col = 0; col < wallSize; col++)
                {
                    Console.Write(wall[row, col]);
                }
                Console.WriteLine();
            }



            //Valid Index Checked Method
            static bool IndexCheck(int wallSize, int row, int col)
            {
                if (row >= 0 && row < wallSize && col >= 0 && col < wallSize)
                {
                    return true;
                }
                return false;
            }

            //Rod Check
            static bool RodCheck(char[,] wall, int row, int col)
            {
                if (wall[row, col] == 'R')
                {
                    return true;
                }
                return false;
            }

            //Hole Check
            static bool HoleCheck(char[,] wall, int row, int col)
            {
                if (wall[row, col] == '*')
                {
                    return true;
                }
                return false;
            }
        }
    }
}