//INPUT
int studentsCount = int.Parse(Console.ReadLine());

//ACTION
Dictionary<string, List<decimal>> studentsDict = new Dictionary<string, List<decimal>>();

for (int i = 0; i < studentsCount; i++)
{
    string[] studentInfo = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

    string currentName = studentInfo[0];
    decimal currentGrade = decimal.Parse(studentInfo[1]);

    if (studentsDict.ContainsKey(currentName))
    {
        studentsDict[currentName].Add(currentGrade);
    }
    else
    {
        List<decimal> grades = new List<decimal>
        {
            currentGrade
        };
            studentsDict.Add(currentName, grades);
    }
}

//OUTPUT
foreach (var student in studentsDict)
{
    Console.Write($"{student.Key} -> ");

    for (int i = 0; i < student.Value.Count; i++)
    {
        Console.Write($"{student.Value[i]:f2} ");
    }

    Console.WriteLine($"(avg: {student.Value.Average():f2})");
}