//INPUT
Func<string, int[]> readIntegers = input => input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
.Select(int.Parse)
.ToArray();

int[] numbers = readIntegers(Console.ReadLine());

//Commands
Func<int, int> calculator = null;
Action<int> printer = null;

string command = string.Empty;
while ((command = Console.ReadLine()) != "end")
{
    //Printing
    if (command == "print")
    {
        Console.WriteLine(String.Join(" ", numbers));
    }

    //Calculations
    else
    {
        calculator = number =>
        {
            if (command == "add")
            {
                number = number += 1;
            }
            else if (command == "multiply")
            {
                number = number *= 2;
            }
            else if (command == "subtract")
            {
                number = number -= 1;
            }
            return number;
        };

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = calculator(numbers[i]);
        }
    }
}