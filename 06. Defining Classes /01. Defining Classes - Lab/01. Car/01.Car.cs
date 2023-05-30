using CarManufacturer;

public class StartUp
{
    static void Main()
    {
        Car currentCar = new Car();

        currentCar.Make = "VW";
        currentCar.Model = "MK3";
        currentCar.Year = 1992;

        Console.WriteLine($"Make: {currentCar.Make}\nModel: {currentCar.Model}\nYear: {currentCar.Year}");
    }
}

