using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] array = ArrayCreator.Create(5, "pesho");

            Console.WriteLine(String.Join(",", array));
        }
    }
}
