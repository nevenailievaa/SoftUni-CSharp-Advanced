using System.Text;

namespace AutomotiveRepairShop
{
    public class RepairShop
    {
        //Properties
        public int Capacity { get; private set; }
        public List<Vehicle> Vehicles { get; set; }

        //Constructor
        public RepairShop(int capacity)
        {
            Capacity = capacity;
            Vehicles = new List<Vehicle>();
        }

        //Methods
        public void AddVehicle(Vehicle vehicle)
        {
            if (Vehicles.Count < Capacity)
            {
                Vehicles.Add(vehicle);
            }
        }

        public bool RemoveVehicle(string vin)
        {
            Vehicle vehicle = Vehicles.Find(v => v.VIN == vin);
            if (vehicle != null)
            {
                Vehicles.Remove(vehicle);
                return true;
            }
            return false;
        }
        
        public int GetCount()
        {
            return Vehicles.Count;
        }

        public Vehicle GetLowestMileage() => Vehicles.Find(x => x.Mileage == Vehicles.Min(y => y.Mileage));

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Vehicles in the preparatory:");

            foreach (Vehicle vehicle in Vehicles)
            {
                sb.AppendLine(vehicle.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}