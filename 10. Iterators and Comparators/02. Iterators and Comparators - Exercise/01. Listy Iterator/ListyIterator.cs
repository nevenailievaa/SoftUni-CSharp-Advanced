namespace ListyIterator;

public class ListyIterator<T>
{
    public ListyIterator(List<T> items)
    {
        Items = items;
    }

    //Properties
    private int Index;
    private List<T> Items { get; set; }

    //Methods
    public bool Move()
    {
        if (Index < Items.Count-1)
        {
            Index++;
            return true;
        }
        
        return false;
    }

    public bool HasNext()
    {
        return Index < Items.Count-1;
    }

    public void Print()
    {
        if (Items.Count > 0)
        {
            Console.WriteLine(Items[Index]);
        }
        else
        {
            throw new InvalidOperationException("Invalid Operation!");
        }
    }
}