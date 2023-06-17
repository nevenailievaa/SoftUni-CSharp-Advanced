namespace AutomotiveRepairShop
{
    public class Vehicle
    {
        //Constructor
        public Vehicle(string vin, int mileage, string damage)
        {
            VIN = vin;
            Mileage = mileage;
            Damage = damage;
        }

        //Properties
        public string VIN { get; private set; }
        public int Mileage { get; private set; }
        public string Damage { get; private set; }

        //Methods
        public override string ToString()
        {
            return $"Damage: {Damage}, Vehicle: {VIN} ({Mileage} km)";
        }
    }
}