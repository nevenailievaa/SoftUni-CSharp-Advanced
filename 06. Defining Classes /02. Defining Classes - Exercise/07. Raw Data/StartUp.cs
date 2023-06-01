namespace DefiningClasses;

internal class StartUp
{
    static void Main(string[] args)
    {
        //INPUT
        int carsCount = int.Parse(Console.ReadLine());

        //Reading The Cars
        List<Car> cars = new List<Car>();

        for (int i = 0; i < carsCount; i++)
        {
            string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Engine currentEngine = new Engine(int.Parse(carInfo[1]), int.Parse(carInfo[2]));
            Cargo currentCargo = new Cargo(int.Parse(carInfo[3]), carInfo[4]);
            
            Tire tireOne = new Tire(int.Parse(carInfo[6]), float.Parse(carInfo[5]));
            Tire tireTwo = new Tire(int.Parse(carInfo[8]), float.Parse(carInfo[7]));
            Tire tireThree = new Tire(int.Parse(carInfo[10]), float.Parse(carInfo[9]));
            Tire tireFour = new Tire(int.Parse(carInfo[12]), float.Parse(carInfo[11]));

            Tire[] currentTires = new Tire[]
            {
                tireOne,
                tireTwo,
                tireThree,
                tireFour
            };

            Car currentCar = new Car(carInfo[0], currentEngine, currentCargo, currentTires);
            cars.Add(currentCar);
        }


        string command = Console.ReadLine();
        string[] filteredCarModels;

        if (command == "fragile")
        {
            filteredCarModels = cars
                .Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1))
                .Select(c => c.Model)
                .ToArray();
        }
        else
        {
            filteredCarModels = cars
                .Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250)
                .Select(c => c.Model)
                .ToArray();
        }

        //OUTPUT
        Console.WriteLine(string.Join(Environment.NewLine, filteredCarModels));
    }
}