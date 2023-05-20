//INPUT
int continentsCnt = int.Parse(Console.ReadLine());

//ACTION
Dictionary<string, Dictionary<string, List<string>>> continentsInfo = 
    new Dictionary<string, Dictionary<string, List<string>>>();

for (int i = 0; i < continentsCnt; i++)
{
    string[] countryInfo = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    string continent = countryInfo[0];
    string country = countryInfo[1];
    string city = countryInfo[2];

    //Already a Continent
    if (continentsInfo.ContainsKey(continent))
    {
        //Already a Country
        if (continentsInfo[continent].ContainsKey(country))
        {
            continentsInfo[continent][country].Add(city);
        }
        ////Not a Country
        else
        {
            List<string> cities = new List<string>()
            {
                city
            };
            continentsInfo[continent].Add(country, cities);
        }
    }
    //Not a Continent
    else
    {
        List<string> cities = new List<string>()
        {
            city
        };
        Dictionary<string, List<string>> countryAndCity = new Dictionary<string, List<string>>()
        {
            { country, cities },
        };
        continentsInfo.Add(continent, countryAndCity);
    }
}

//OUTPUT
foreach (var (continent, countryAndCities) in continentsInfo)
{
    Console.WriteLine($"{continent}:");

    foreach (var (country, cities) in countryAndCities)
    {
        Console.WriteLine($"{country} -> {string.Join(", ", cities)}");
    }
}