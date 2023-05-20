//INPUT
string command = string.Empty;

//ACTION
SortedDictionary<string, Dictionary<string, double>> shopsStorages = new SortedDictionary<string, Dictionary<string, double>>();

while ((command = Console.ReadLine()) != "Revision")
{
    string[] shopInfo = command
        .Split(", ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    string shopName = shopInfo[0];
    string product = shopInfo[1];
    double price = double.Parse(shopInfo[2]);

    if (shopsStorages.ContainsKey(shopName))
    {
        shopsStorages[shopName].Add(product, price);
    }
    else
    {
         Dictionary<string, double> products = new Dictionary<string, double>()
        {
            {product, price}
        };
        shopsStorages.Add(shopName, products);
    }
}

//OUTPUT
foreach (var (shopName, storage) in shopsStorages)
{
    Console.WriteLine($"{shopName}->");

    foreach (var (product, price) in storage)
    {
        Console.WriteLine($"Product: {product}, Price: {price}");
    }
}