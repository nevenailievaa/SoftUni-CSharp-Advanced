using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.TilesMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            Stack<int> whiteTiles = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Queue<int> greyTiles = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Dictionary<string, int> tileAreas = new Dictionary<string, int>()
            {
                {"Sink", 0 },
                {"Oven", 0 },
                {"Countertop", 0},
                {"Wall", 0 },
                {"Floor", 0 }
            };


            //ACTION

            while (whiteTiles.Any() && greyTiles.Any())
            {
                int sum = 0;
                bool isMatch = false;

                if (whiteTiles.Peek() == greyTiles.Peek())
                {
                    sum = whiteTiles.Peek() + greyTiles.Peek();
                }
                else
                {
                    int areaToDecrease = whiteTiles.Pop() / 2;
                    int greyAreaToMove = greyTiles.Dequeue();

                    whiteTiles.Push(areaToDecrease);
                    greyTiles.Enqueue(greyAreaToMove);

                    continue;
                }

                //Sink
                if (sum == 40)
                {
                    tileAreas["Sink"]+= 1;
                    isMatch = true;
                }
                //Oven
                else if (sum == 50)
                {
                    tileAreas["Oven"]+= 1;
                    isMatch = true;
                }
                //Countertop
                else if (sum == 60)
                {
                    tileAreas["Countertop"]+= 1;
                    isMatch = true;
                }
                //Wall
                else if (sum == 70)
                {
                    tileAreas["Wall"]+= 1;
                    isMatch = true;
                }
                //Floor
                else
                {
                    tileAreas["Floor"]+= 1;
                    isMatch = true;
                }

                //Match Check
                if (isMatch)
                {
                    whiteTiles.Pop();
                    greyTiles.Dequeue();
                }
            }

            //OUTPUT
            //White Tiles
            if (!whiteTiles.Any())
            {
                Console.WriteLine("White tiles left: none");
            }
            else
            {
                Console.Write("White tiles left: ");
                Console.WriteLine(String.Join(", ", whiteTiles));
            }

            //Grey Tiles
            if (!greyTiles.Any())
            {
                Console.WriteLine("Grey tiles left: none");
            }
            else
            {
                Console.Write("Grey tiles left: ");
                Console.WriteLine(String.Join(", ", greyTiles));
            }

            //Kitchen Locations
            foreach (var area in tileAreas.Where(a => a.Value > 0).OrderByDescending(a => a.Value).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{area.Key}: {area.Value}");
            }
        }
    }
}