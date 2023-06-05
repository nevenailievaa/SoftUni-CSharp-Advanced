namespace CustomStructures;

internal class CustomQueue
{
    public int[] Items { get; set; }
    public int Count { get; private set; }

    private const int Capacity = 4;


    //Constructor
    public CustomQueue()
    {
        Items = new int[Capacity];
    }

    //Public Methods
    public void Enqueue(int value)
    {
        if (Count == Items.Length-1)
        {
            Resize();
        }

        Items[Count] = value;
        Count++;
    }

    public int Dequeue()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("CustomQueue is empty!");
        }
        else if (Count <= Items.Length / 4)
        {
            Shrink();
        }

        int removedElement = Items[0];
        ShiftLeft();
        Count--;

        return removedElement;
    }

    public int Peek()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("CustomQueue is empty!");
        }

        return Items[0];
    }

    public void Clear()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("CustomQueue is empty!");
        }

        for (int i = 0; i < Count; i++)
        {
            Items[i] = default;
        }
        Count = 0;
    }

    public void ForEach(Action<int> action)
    {
        if (Items.Length == 0)
        {
            throw new InvalidOperationException("CustomQueue is empty!");
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

    private void ShiftLeft()
    {
        for (int i = 0; i < Count; i++)
        {
            Items[i] = Items[i+1];
        }
    }
}
