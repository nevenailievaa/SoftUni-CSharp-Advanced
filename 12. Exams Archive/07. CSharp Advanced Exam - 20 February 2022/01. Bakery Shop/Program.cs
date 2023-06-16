using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BakeryShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            Queue<double> water = new Queue<double>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray());

            Stack<double> flour = new Stack<double>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray());

            Dictionary<string, int> bakedMeals = new Dictionary<string, int>()
            {
                {"Croissant" , 0 },
                {"Muffin" , 0 },
                {"Baguette" , 0 },
                {"Bagel" , 0 },
            };

            //ACTION
            while (water.Any() && flour.Any())
            {
                double waterValue = water.Peek();
                double flourValue = flour.Peek();
                double mix = waterValue + flourValue;

                bool isBaked = false;

                //Croissant
                if (waterValue == mix * 0.5 && flourValue == mix * 0.5)
                {
                    isBaked = true;
                    bakedMeals["Croissant"] += 1;
                }

                //Muffin
                else if(waterValue == mix * 0.4 && flourValue == mix * 0.6)
                {
                    isBaked = true;
                    bakedMeals["Muffin"] += 1;
                }

                //Baguette
                else if(waterValue == mix * 0.3 && flourValue == mix * 0.7)
                {
                    isBaked = true;
                    bakedMeals["Baguette"] += 1;
                }

                //Bagel
                else if (waterValue == mix * 0.2 && flourValue == mix * 0.8)
                {
                    isBaked = true;
                    bakedMeals["Bagel"] += 1;
                }

                //Best Selling Bakery Product - Croissant
                else
                {
                    double currentFlour = flour.Pop();
                    double flourToAdd = water.Dequeue();
                    flour.Push(currentFlour - flourToAdd);
                    bakedMeals["Croissant"] += 1;
                }

                //If Is Baked
                if (isBaked)
                {
                    water.Dequeue();
                    flour.Pop();
                }
            }

            //OUTPUT
            foreach (var item in bakedMeals.Where(i => i.Value > 0).OrderByDescending(i => i.Value).ThenBy(i => i.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            //Water
            if (water.Any())
            {
                Console.WriteLine($"Water left: {String.Join(", ", water)}");
            }
            else
            {
                Console.WriteLine("Water left: None");
            }

            //Flour
            if (flour.Any())
            {
                Console.WriteLine($"Flour left: {String.Join(", ", flour)}");
            }
            else
            {
                Console.WriteLine("Flour left: None");
            }
        }
    }
}