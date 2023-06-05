namespace CustomStructures;

internal class CustomStack
{
    public int[] Items { get; set; }
    public int Count { get; private set; }

    private const int Capacity = 4;


    //Constructor
    public CustomStack()
    {
        Items = new int[Capacity];
    }


    //Public Methods
    public void Push(int value)
    {
        if (Items.Length == Count)
        {
            Resize();
        }

        Items[Count] = value;
        Count++;
    }

    public int Pop()
    {
        if (Items.Length == 0) 
        {
            throw new InvalidOperationException("CustomStack is empty!");
        }
        else if (Count <= Items.Length / 4)
        {
            Shrink();
        }

        int removedElement = Items[Count - 1];
        Items[Count - 1] = default;
        Count--;
        return removedElement;
    }

    public int Peek()
    {
        if (Items.Length == 0)
        {
            throw new InvalidOperationException("CustomStack is empty!");
        }

        return Items[Count-1];
    }

    public void ForEach(Action<int> action)
    {
        if (Items.Length == 0)
        {
            throw new InvalidOperationException("CustomStack is empty!");
        }

        for (int i = 0; i < Count; i++)
        {
            action(Items[i]);
        }
    }

    public void Print()
    {
        for (int i = 0; i < Count-1; i++)
        {
            Console.Write(Items[i] + ", ");
        }
        Console.WriteLine(Items[Count-1]);
    }

    //Private Methods
    private void Resize()
    {
        int[] copy = new int[Items.Length * 2];

        for (int i = 0; i < Count; i++)
        {
            copy[i] = Items[i];
        }

        Items = copy;
    }

    private void Shrink()
    {
        int[] copy = new int[Items.Length / 2];

        for (int i = 0; i < Count; i++)
        {
            copy[i] = Items[i];
        }

        Items = copy;
    }
}
