namespace CarManufacturer;

public class StartUp
{
    public static void Main(string[] args)
    {
        string command = string.Empty;

        List<Tire[]> tiresList = new List<Tire[]>();

        //Tires Collection
        while ((command = Console.ReadLine()) != "No more tires")
        {
            string[] tireInfo = command
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int tire1Year = int.Parse(tireInfo[0]);
            double tire1Pressure = double.Parse(tireInfo[1]);
            int tire2Year = int.Parse(tireInfo[2]);
            double tire2Pressure = double.Parse(tireInfo[3]);
            int tire3Year = int.Parse(tireInfo[4]);
            double tire3Pressure = double.Parse(tireInfo[5]);
            int tire4Year = int.Parse(tireInfo[6]);
            double tire4Pressure = double.Parse(tireInfo[7]);


            Tire tireOne = new Tire(tire1Year, tire1Pressure);
            Tire tireTwo = new Tire(tire2Year, tire2Pressure);
            Tire tireThree = new Tire(tire3Year, tire3Pressure);
            Tire tireFour = new Tire(tire4Year, tire4Pressure);

            Tire[] carTires = new Tire[4]
            {
                tireOne,
                tireTwo,
                tireThree,
                tireFour
            };

            tiresList.Add(carTires);
        }

        //Engines Collection
        List<Engine> enginesList = new List<Engine>();

        while ((command = Console.ReadLine()) != "Engines done")
        {
            string[] engineInfo = command
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int engineHP = int.Parse(engineInfo[0]);
            double engineCubicCapacity = double.Parse(engineInfo[1]);

            Engine currentEngine = new Engine(engineHP, engineCubicCapacity);
            enginesList.Add(currentEngine);
        }

        //Showing Special
        List<Car> carsList = new List<Car>();

        while ((command = Console.ReadLine()) != "Show special")
        {
            string[] carInfo = command
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            //Input Info
            string make = carInfo[0];
            string model = carInfo[1];
            int year = int.Parse(carInfo[2]);
            double fuelQuantity = double.Parse(carInfo[3]);
            double fuelConsumption = double.Parse(carInfo[4]);
            int engineIndex = int.Parse(carInfo[5]);
            int tireIndex = int.Parse(carInfo[6]);

            //Finding Engine And Tires
            Engine currentEngine = enginesList[engineIndex];
            Tire[] currentTires = tiresList[tireIndex];

            Car currentCar = new Car(make, model, year, fuelQuantity, fuelConsumption, currentEngine, currentTires);
            carsList.Add(currentCar);
        }

        //Filtering
        List<Car> filteredCars = carsList
            .Where(x => x.Year >= 2017)
            .Where(x => x.Engine.HorsePower > 330)
            .Where(x => x.Tires.Sum(p => p.Pressure) >= 9
                        && x.Tires.Sum(p => p.Pressure) <= 10)
            .ToList();

        //Driving and Printing
        foreach (var filteredCar in filteredCars)
        {
            filteredCar.Drive(20);
            Console.WriteLine(filteredCar.WhoAmI());
        }
    }
}