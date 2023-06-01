namespace DefiningClasses;

internal class StartUp
{
    static void Main(string[] args)
    {
        //INPUT
        int carsCount = int.Parse(Console.ReadLine());

        //ACTION
        Dictionary<string, Car> carsByNames = new Dictionary<string, Car>();

        for (int i = 0; i < carsCount; i++)
        {
            string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string model = carInfo[0];
            double fuelAmount = double.Parse(carInfo[1]);
            double fuelConsumptionPerKilometer = double.Parse(carInfo[2]);

            Car car = new Car(model, fuelAmount, fuelConsumptionPerKilometer, 0);
            carsByNames.Add(model, car);
        }

        //Commands
        string command = string.Empty;

        while ((command = Console.ReadLine()) != "End")
        {
            string[] carInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string model = carInfo[1];
            double amountOfKm = double.Parse(carInfo[2]);

            Car currentCar = carsByNames[model];
            currentCar.Drive(amountOfKm);
        }

        //OUTPUT
        foreach (var car in carsByNames.Values)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
        }
    }
}