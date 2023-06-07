using System.Text;
using Threeuple;

//INPUT
//Person Adress Info
string[] nameAndAdressInfo = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();
string name = nameAndAdressInfo[0] + " " + nameAndAdressInfo[1];
string adress = nameAndAdressInfo[2];

StringBuilder town = new StringBuilder();
if (nameAndAdressInfo.Length > 3)
{
    for (int i = 3; i < nameAndAdressInfo.Length; i++)
    {
        if (i < nameAndAdressInfo.Length -1)
        {
            town.Append(nameAndAdressInfo[i] + " ");
        }
        else
        {
            town.Append(nameAndAdressInfo[i]);
        }
    }
}


//Person Beer Info
string[] nameAndBeerInfo = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();
string nameBeer = nameAndBeerInfo[0];
int liters = int.Parse(nameAndBeerInfo[1]);
bool isDrunk = false;

if (nameAndBeerInfo[2] == "drunk")
{
    isDrunk = true;
}


//Bank Info
string[] bankInfo = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

string nameBankPerson = bankInfo[0];
double balance = double.Parse(bankInfo[1]);
string bankName = bankInfo[2];


//ACTION
Threeuple<string, string, StringBuilder> nameAndAdress =
    new Threeuple<string, string, StringBuilder>(name, adress, town);

Threeuple<string, int, bool> nameAndBeer =
    new Threeuple<string, int, bool>(nameBeer, liters, isDrunk);

Threeuple<string, double, string> bankPerson =
    new Threeuple<string, double, string>(nameBankPerson, balance, bankName);

//OUTPUT
Console.WriteLine(nameAndAdress.ToString());
Console.WriteLine(nameAndBeer.ToString());
Console.WriteLine(bankPerson.ToString());