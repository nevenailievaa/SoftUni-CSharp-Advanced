using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _02.BeaverAtWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int pondSize = int.Parse(Console.ReadLine());
            char[,] pond = new char[pondSize, pondSize];
            int beaverRow = 0;
            int beaverCol = 0;
            int woodBranchesSum = 0;

            for (int row = 0; row < pondSize; row++)
            {
                string[] colInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < pondSize; col++)
                {
                    pond[row, col] = char.Parse(colInfo[col]);

                    if (pond[row, col] =='B')
                    {
                        beaverRow = row;
                        beaverCol = col;
                    }
                    else if (char.IsLower(pond[row, col]))
                    {
                        woodBranchesSum++;
                    }
                }
            }

            //ACTION
            List<char> woodBranches = new List<char>(); 

            string command = string.Empty;
            while((command = Console.ReadLine()) != "end" && woodBranches.Count < woodBranchesSum)
            {
                Move(command, ref pond, pondSize, ref beaverRow, ref beaverCol, ref woodBranches, ref woodBranchesSum);
            }

            //OUTPUT
            if (woodBranchesSum == woodBranches.Count)
            {
                Console.WriteLine($"The Beaver successfully collect {woodBranches.Count} wood branches: {String.Join(", ", woodBranches)}.");
            }
            else
            {
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {woodBranchesSum - woodBranches.Count} branches left.");
            }

            PrintPond(pond, pondSize);



            //Moving Method
            static void Move(string command, ref char[,] pond, int pondSize, ref int row, ref int col, ref List<char> woodBranches, ref int woodBranchesSum)
            {
                bool moveIsMade = false;

                //Up
                if (command == "up")
                {
                    if (CheckIndex(pondSize, row-1, col))
                    {
                        moveIsMade = true;
                        pond[row, col] = '-';
                        row--;
                    }
                    else
                    {
                        if (woodBranches.Count > 0)
                        {
                            woodBranches.RemoveAt(woodBranches.Count-1);
                            woodBranchesSum--;
                        }
                    }
                }

                //Down
                else if (command == "down")
                {
                    if (CheckIndex(pondSize, row+1, col))
                    {
                        moveIsMade = true;
                        pond[row, col] = '-';
                        row++;
                    }
                    else
                    {
                        if (woodBranches.Count > 0)
                        {
                            woodBranches.RemoveAt(woodBranches.Count-1);
                            woodBranchesSum--;
                        }
                    }
                }

                //Left
                else if (command == "left")
                {
                    if (CheckIndex(pondSize, row, col-1))
                    {
                        moveIsMade = true;
                        pond[row, col] = '-';
                        col--;
                    }
                    else
                    {
                        if (woodBranches.Count > 0)
                        {
                            woodBranches.RemoveAt(woodBranches.Count-1);
                            woodBranchesSum--;
                        }
                    }
                }

                //Right
                else if (command == "right")
                {
                    if (CheckIndex(pondSize, row, col+1))
                    {
                        moveIsMade = true;
                        pond[row, col] = '-';
                        col++;
                    }
                    else
                    {
                        if (woodBranches.Count > 0)
                        {
                            woodBranches.RemoveAt(woodBranches.Count-1);
                            woodBranchesSum--;
                        }
                    }
                }

                //Move Made Check
                if (moveIsMade)
                {
                    //Fish Swimming Chek
                    if (pond[row, col] == 'F')
                    {
                        pond[row, col] = '-';

                        if (command == "up")
                        {
                            if (row == 0)
                            {
                                row = pondSize-1;
                            }
                            else
                            {
                                row = 0;
                            }
                        }
                        else if (command == "down")
                        {
                            if (row == pondSize)
                            {
                                row = 0;
                            }
                            else
                            {
                                row = pondSize;
                            }

                        }
                        else if (command == "left")
                        {
                            if (col == 0)
                            {
                                col = pondSize-1;
                            }
                            else
                            {
                                col = 0;
                            }
                        }
                        else if (command == "right")
                        {
                            if (col == pondSize)
                            {
                                col = 0;
                            }
                            else
                            {
                                col = pondSize;
                            }
                        }
                    }

                    //Wood Branch Check
                    if (char.IsLower(pond[row, col]))
                    {
                        woodBranches.Add(pond[row, col]);
                    }
                }
                pond[row, col] = 'B';
            }

            //Index Checker
            static bool CheckIndex (int pondSize, int row, int col)
            {
                if (row >= 0 && row < pondSize && col >= 0 && col < pondSize)
                {
                    return true;
                }
                return false;
            }

            //Pond Printer
            static void PrintPond(char[,] pond, int pondSize)
            {
                for (int row = 0; row < pondSize; row++)
                {
                    for (int col = 0; col < pondSize; col++)
                    {
                        if (col < pondSize-1)
                        {
                            Console.Write(pond[row, col] + " ");
                        }
                        else
                        {
                            Console.Write(pond[row, col]);
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}