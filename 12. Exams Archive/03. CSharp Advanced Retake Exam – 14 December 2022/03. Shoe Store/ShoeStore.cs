using System.Text;

namespace ShoeStore
{
    public class ShoeStore
    {
        //Constructor
        public ShoeStore(string name, int storageCapacity)
        {
            Name = name;
            StorageCapacity = storageCapacity;
            Shoes = new List<Shoe>();
        }

        //Properties
        public string Name { get; set; }
        public int StorageCapacity { get; set; }
        public List<Shoe> Shoes { get; set; }
        public int Count => Shoes.Count;

        //Methods
        public string AddShoe(Shoe shoe)
        {
            if (StorageCapacity == Count)
            {
                return "No more space in the storage room.";
            }
            Shoes.Add(shoe);
            return $"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.";
        }

        public int RemoveShoes(string material)
        {
            int removedShoesCount = 0;

            for (int i = 0; i < Count; i++)
            {
                if (Shoes[i].Material == material)
                {
                    Shoes.RemoveAt(i);
                    removedShoesCount++;
                    i--;
                }
            }
            return removedShoesCount;
        }

        public List<Shoe> GetShoesByType(string type)
        {
            List<Shoe> shoes = new List<Shoe>();

            for (int i = 0; i < Count; i++)
            {
                if (Shoes[i].Type.ToLower() == type.ToLower())
                {
                    shoes.Add(Shoes[i]);
                }
            }
            return shoes;
        }

        public Shoe GetShoeBySize(double size)
        {
            Shoe shoe = Shoes.FirstOrDefault(s => s.Size == size);
            return shoe;
        }

        public string StockList(double size, string type)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Stock list for size {size} - {type} shoes:");
            bool matchedShoes = false;

            foreach (Shoe shoe in Shoes.Where(s => s.Size == size && s.Type == type))
            {
                sb.AppendLine(shoe.ToString());
                matchedShoes = true;
            }

            if (!matchedShoes)
            {
                return "No matches found!";
            }
            return sb.ToString().TrimEnd();
        }
    }
}
