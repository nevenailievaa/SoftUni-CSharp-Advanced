using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.MealPlan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            Queue<string> meals = new Queue<string>(Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToArray());

            Stack<int> calories = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Dictionary<string, int> mealsTable = new Dictionary<string, int>()
            {
                {"salad", 350 },
                {"soup", 490 },
                {"pasta", 680 },
                {"steak", 790 }
            };

            //ACTION
            int mealsAte = 0;

            while (meals.Any() && calories.Any())
            {
                string currentMeal = meals.Peek();
                int currentCalories = calories.Peek();

                bool isAte = false;

                //Meals
                if (mealsTable.ContainsKey(currentMeal))
                {
                    isAte = true;
                }

                //Is Ate Check
                if (isAte)
                {
                    mealsAte++;
                    currentCalories -= mealsTable[currentMeal];
                    meals.Dequeue();

                    if (currentCalories == 0)
                    {
                        calories.Pop();
                    }
                    else if (currentCalories < 0)
                    {
                        int additionalCalories = Math.Abs(currentCalories);
                        calories.Pop();

                        if (calories.Any())
                        {
                            int nextDayCalories = calories.Pop() - additionalCalories;
                            calories.Push(nextDayCalories);
                        }
                    }
                    else
                    {
                        calories.Pop();
                        calories.Push(currentCalories);
                    }
                }
            }

            //OUTPUT
            if (meals.Any())
            {
                Console.WriteLine($"John ate enough, he had {mealsAte} meals.");
                Console.WriteLine($"Meals left: {String.Join(", ", meals)}.");
            }
            else
            {
                Console.WriteLine($"John had {mealsAte} meals.");
                Console.WriteLine($"For the next few days, he can eat {String.Join(", ", calories)} calories.");
            }
        }
    }
}