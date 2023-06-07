using System.Text;

namespace GenericBoxОfString;

public class Box<T>
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
}
