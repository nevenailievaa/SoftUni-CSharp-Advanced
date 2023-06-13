using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BaristaContest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            Queue<int> coffee = new Queue<int>(Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Stack<int> milk = new Stack<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Dictionary<string, int> coffeeDrinksMade = new Dictionary<string, int>()
            {
                {"Cortado", 0 },
                {"Espresso", 0 },
                {"Capuccino", 0 },
                {"Americano", 0 },
                {"Latte", 0 }
            };

            //ACTION
            while (coffee.Any() && milk.Any())
            {
                int sum = coffee.Peek() + milk.Peek();
                bool isMade = false;

                //Coffee Drinks
                if (sum == 50)
                {
                    coffeeDrinksMade["Cortado"] += 1;
                    isMade = true;
                }
                else if (sum == 75)
                {
                    coffeeDrinksMade["Espresso"] += 1;
                    isMade = true;
                }
                else if (sum == 100)
                {
                    coffeeDrinksMade["Capuccino"] += 1;
                    isMade = true;
                }
                else if (sum == 150)
                {
                    coffeeDrinksMade["Americano"] += 1;
                    isMade = true;
                }
                else if (sum == 200)
                {
                    coffeeDrinksMade["Latte"] += 1;
                    isMade = true;
                }

                //If Any Coffee Is Made
                if (isMade)
                {
                    coffee.Dequeue();
                    milk.Pop();
                }
                else
                {
                    coffee.Dequeue();
                    int milkValue = milk.Pop() - 5;
                    milk.Push(milkValue);
                }
            }

            //OUTPUT
            if (!coffee.Any() && !milk.Any())
            {
                Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
            }
            else
            {
                Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
            }

            //Coffee Left
            if (coffee.Count == 0)
            {
                Console.WriteLine("Coffee left: none");
            }
            else
            {
                Console.Write("Coffee left: ");
                Console.WriteLine(String.Join(", ", coffee));
            }

            //Milk Left
            if (milk.Count == 0)
            {
                Console.WriteLine("Milk left: none");
            }
            else
            {
                Console.Write("Milk left: ");
                Console.WriteLine(String.Join(", ", milk));
            }

            //Drinks Print
            foreach (var item in coffeeDrinksMade.Where(d => d.Value > 0).OrderBy(d => d.Value).ThenByDescending(d => d.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
