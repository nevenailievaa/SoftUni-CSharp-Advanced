using System.Text;

namespace ClothesMagazine
{
    public class Cloth
    {
        //Constructor
        public Cloth(string color, int size, string type)
        {
            Color = color;
            Size = size;
            Type = type;
        }

        //Properties
        public string Color { get; set; }
        public int Size { get; set; }
        public string Type { get; set; }

        //Methods
        public override string ToString()
        {
            return $"Product: {this.Type} with size {this.Size}, color {this.Color}";
        }
    }
}
