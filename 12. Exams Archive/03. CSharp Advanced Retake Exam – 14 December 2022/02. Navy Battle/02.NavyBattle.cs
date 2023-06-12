//INPUT
int battlefieldSize = int.Parse(Console.ReadLine());
char[,] battlefield = new char[battlefieldSize,battlefieldSize];
int submarineRow = 0;
int submarineCol = 0;

for (int row = 0; row < battlefieldSize; row++)
{
    string battlefieldInfo = Console.ReadLine();

    for (int col = 0; col < battlefieldSize; col++)
	{
        battlefield[row, col] = battlefieldInfo[col];

        if (battlefieldInfo[col] == 'S')
        {
            submarineRow = row;
            submarineCol = col;
        }
    }
}

//ACTION
string command = string.Empty;
int hitsCount = 0;
int destroyedCruisersCount = 0;

while (hitsCount < 3 && destroyedCruisersCount < 3)
{
    command = Console.ReadLine();

    if (command == "up")
    {
        battlefield[submarineRow, submarineCol] = '-';
        submarineRow--;
    }
    else if (command == "down")
    {
        battlefield[submarineRow, submarineCol] = '-';
        submarineRow++;
    }
    else if (command == "left")
    {
        battlefield[submarineRow, submarineCol] = '-';
        submarineCol--;
    }
    else if (command == "right")
    {
        battlefield[submarineRow, submarineCol] = '-';
        submarineCol++;
    }

    //Mine Check
    if (battlefield[submarineRow, submarineCol] == '*')
    {
        battlefield[submarineRow, submarineCol] = '-';
        hitsCount += 1;
        battlefield[submarineRow, submarineCol] = 'S';
    }

    //Cruiser Check
    else if (battlefield[submarineRow, submarineCol] == 'C')
    {
        battlefield[submarineRow, submarineCol] = '-';
        destroyedCruisersCount += 1;
        battlefield[submarineRow, submarineCol] = 'S';
    }
}

//OUTPUT
if (hitsCount == 3)
{
    Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{submarineRow}, {submarineCol}]!");
}
else if (destroyedCruisersCount == 3)
{
    Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
}

for (int row = 0; row < battlefieldSize; row++)
{
    for (int col = 0; col < battlefieldSize; col++)
    {
        Console.Write(battlefield[row, col]);
    }
    Console.WriteLine();
}