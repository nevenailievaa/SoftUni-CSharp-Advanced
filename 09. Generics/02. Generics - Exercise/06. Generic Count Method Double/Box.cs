using System.Text;

namespace GenericBoxОfString;

public class Box<T> where T : IComparable<T>
{
    private List<T> Items { get; set; }

    //Constructor
    public Box()
    {
        Items = new List<T>();
    }

    //Methods
    public void Add(T item)
    {
        Items.Add(item);
    }

    public override string ToString()
    {
        StringBuilder sb = new();

        foreach (var item in Items)
        {
            sb.AppendLine($"{typeof(T)}: {item}");
        }

        return sb.ToString().TrimEnd();
    }

    public void Swap(int indexOne, int indexTwo)
    {
        T currentItem = Items[indexOne];

        Items[indexOne] = Items[indexTwo];
        Items[indexTwo] = currentItem;
    }

    public int Compare(T itemToCompare)
    {
        int count = 0;

        foreach (var item in Items)
        {
            if (item.CompareTo(itemToCompare) > 0)
            {
                count++;
            }
        }

        return count;
    }
}