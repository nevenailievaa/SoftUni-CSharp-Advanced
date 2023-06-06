using System;
using System.Collections.Generic;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            EqualityScale<int> ints = new EqualityScale<int>(a, b);

            if (ints.AreEqual())
            {
                Console.WriteLine("Numbers are equal!");
            }
            else
            {
                Console.WriteLine("Numbers are not equal!");
            }


            string Astring = Console.ReadLine();
            string Bstring = Console.ReadLine();

            EqualityScale<string> strings = new EqualityScale<string>(Astring, Bstring);

            if (strings.AreEqual())
            {
                Console.WriteLine("Strings are equal!");
            }
            else
            {
                Console.WriteLine("Strings are not equal!");
            }
        }
    }
}