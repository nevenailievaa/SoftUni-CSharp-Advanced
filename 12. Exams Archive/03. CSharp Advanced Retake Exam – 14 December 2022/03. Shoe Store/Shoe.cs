namespace ShoeStore
{
    public class Shoe
    {
        //Constructor
        public Shoe(string brand, string type, double size, string material)
        {
            Brand = brand;
            Type = type;
            Size = size;
            Material = material;
        }

        //Properties
        public string Brand { get; set; }
        public string Type { get; set; }
        public double Size { get; set; }
        public string Material { get; set; }

        //Methods
        public override string ToString()
        {
            return $"Size {Size}, {Material} {Brand} {Type} shoe.";
        }
    }
}
