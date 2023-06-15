using System;
using System.Drawing;
using System.Linq;

namespace _02.TruffleHunter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int forestSize = int.Parse(Console.ReadLine());
            string[,] forest = new string[forestSize, forestSize];

            for (int row = 0; row < forestSize; row++)
            {
                string[] truffelsRowInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < forestSize; col++)
                {
                    forest[row, col] = truffelsRowInfo[col];
                }
            }

            //ACTION
            int blackTruffles = 0;
            int summerTruffles = 0;
            int whiteTruffles = 0;
            int wildBoarEatenTruffles = 0;

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Stop the hunt")
            {
                string[] commandArray = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string commandType = commandArray[0];
                int row = int.Parse(commandArray[1]);
                int col = int.Parse(commandArray[2]);

                //Collectiong Truffles
                if (commandType == "Collect")
                {
                    if (forest[row,col] == "B")
                    {
                        blackTruffles++;
                        forest[row, col] = "-";
                    }
                    else if (forest[row, col] == "S")
                    {
                        summerTruffles++;
                        forest[row, col] = "-";
                    }
                    else if (forest[row, col] == "W")
                    {
                        whiteTruffles++;
                        forest[row, col] = "-";
                    }
                }

                //Wild Boar
                else if (commandType == "Wild_Boar")
                {
                    string direction = commandArray[3];
                    int evenCounter = 0;

                    if (direction == "up")
                    {
                        for (int i = row; i >= 0; i--)
                        {
                            if (evenCounter % 2 == 0)
                            {
                                if (forest[i, col] == "B" || forest[i, col] == "S" || forest[i, col] == "W")
                                {
                                    wildBoarEatenTruffles++;
                                    forest[i, col] = "-";
                                }
                            }
                            evenCounter++;
                        }
                    }

                    //Down
                    else if (direction == "down")
                    {
                        for (int i = row; i < forestSize; i++)
                        {
                            if (evenCounter % 2 == 0)
                            {
                                if (forest[i, col] == "B" || forest[i, col] == "S" || forest[i, col] == "W")
                                {
                                    wildBoarEatenTruffles++;
                                    forest[i, col] = "-";
                                }
                            }
                            evenCounter++;
                        }
                    }

                    //Left
                    else if (direction == "left")
                    {
                        for (int i = col; i >= 0; i--)
                        {
                            if (evenCounter % 2 == 0)
                            {
                                if (forest[row, i] == "B" || forest[row, i] == "S" || forest[row, i] == "W")
                                {
                                    wildBoarEatenTruffles++;
                                    forest[row, i] = "-";
                                }
                            }
                            evenCounter++;
                        }
                    }

                    //Right
                    else if (direction == "right")
                    {
                        for (int i = col; i < forestSize; i++)
                        {
                            if (evenCounter % 2 == 0)
                            {
                                if (forest[row, i] == "B" || forest[row, i] == "S" || forest[row, i] == "W")
                                {
                                    wildBoarEatenTruffles++;
                                    forest[row, i] = "-";
                                }
                            }
                            evenCounter++;
                        }
                    }
                }
            }

            //OUTPUT
            Console.WriteLine($"Peter manages to harvest {blackTruffles} black, {summerTruffles} summer, and {whiteTruffles} white truffles.");
            Console.WriteLine($"The wild boar has eaten {wildBoarEatenTruffles} truffles.");

            for (int row = 0; row < forestSize; row++)
            {
                for (int col = 0; col < forestSize; col++)
                {
                    if (col < forestSize -1)
                    {
                        Console.Write(forest[row, col] + " ");
                    }
                    else
                    {
                        Console.WriteLine(forest[row, col]);
                    }
                }
            }
        }
    }
}