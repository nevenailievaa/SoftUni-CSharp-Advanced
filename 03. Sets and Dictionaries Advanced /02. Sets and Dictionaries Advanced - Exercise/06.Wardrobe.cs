//INPUT
int commandsCount = int.Parse(Console.ReadLine());

//ACTION
Dictionary<string, Dictionary<string, int>> wardrobes = new Dictionary<string, Dictionary<string, int>>();

for (int i = 0; i < commandsCount; i++)
{
    string[] currentWardrobe = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
    string[] currentClothes = currentWardrobe[1].Split(",", StringSplitOptions.RemoveEmptyEntries);
    string currentWardrobeColor = currentWardrobe[0];

    //Already a Color Wardrobe
    if (wardrobes.ContainsKey(currentWardrobeColor))
    {
        for (int j = 0; j < currentClothes.Length; j++)
        {
            //Already a Clothe
            if (wardrobes[currentWardrobeColor].ContainsKey(currentClothes[j]))
            {
                wardrobes[currentWardrobeColor][currentClothes[j]]++;
            }
            //Not a Clothe Yet
            else
            {
                wardrobes[currentWardrobeColor][currentClothes[j]] = 1;
            }
        }
    }

    //Not a Color Wardrobe Yet
    else
    {
        Dictionary<string, int> currentClothe = new Dictionary<string, int>();
        currentClothe.Add(currentClothes[0], 1);
        wardrobes.Add(currentWardrobeColor, currentClothe);

        for (int j = 1; j < currentClothes.Length; j++)
        {
            //Already a Clothe
            if (wardrobes[currentWardrobeColor].ContainsKey(currentClothes[j]))
            {
                wardrobes[currentWardrobeColor][currentClothes[j]]++;
            }
            //Not a Clothe Yet
            else
            {
                wardrobes[currentWardrobeColor][currentClothes[j]] = 1;
            }
        }
    }
}

//Searched clothe
string[] searchedClotheArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
string searchedColorWarderobe = searchedClotheArray[0];
string searchedClothe = searchedClotheArray[1];

//OUTPUT
foreach (var (wardrobeColor, clothes) in wardrobes)
{
    Console.WriteLine($"{wardrobeColor} clothes:");

    foreach (var (clothe, clotheCount) in clothes)
    {
        if (searchedColorWarderobe == wardrobeColor && searchedClothe == clothe)
        {
            Console.WriteLine($"* {clothe} - {clotheCount} (found!)");
        }
        else
        {
            Console.WriteLine($"* {clothe} - {clotheCount}");
        }
    }
}