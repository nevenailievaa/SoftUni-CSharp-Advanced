//iNPUT
int[] integersInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

//ACTION
Queue<int> queue = new Queue<int>(integersInput);
List<int> evenNums = new List<int>();

for (int i = 0; i < integersInput.Length; i++)
{
    int currentNum = queue.Dequeue();

	if (currentNum % 2 == 0)
	{
        evenNums.Add(currentNum);
    }
}

//OUTOUT
Console.WriteLine(String.Join(", ", evenNums));