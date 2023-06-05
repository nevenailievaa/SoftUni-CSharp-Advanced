using System;
using System.Reflection;

namespace CustomStructures;

internal class CustomList
{
    public int[] Items { get; set; }
    public int Count { get; private set; }

    private const int InitialCapacity = 2;

    //Constructor
    public CustomList()
    {
        Items = new int[InitialCapacity];
    }

    public int this[int index]
    {
        get
        {
            ThrowExceptionIfIndexOutOfRange(index);
            return Items[index];
        }
        set
        {
            ThrowExceptionIfIndexOutOfRange(index);
            Items[index] = value;
        }
    }

    //Methods
    public void Add(int value)
    {
        if (Items.Length == Count)
        {
            Resize();
        }
        Items[Count] = value;
        Count++;

        Console.WriteLine($"You successfully added the value {value} at the end of the list!");
    }

    public void InsertAt(int index, int value)
    {
        ThrowExceptionIfIndexOutOfRange(index);

        if (Items.Length == Count)
        {
            Resize();
        }

        ShiftRight(index);
        Items[index] = value;
        Count++;

        Console.WriteLine($"You successfully inserted the value {value} at index {index}!");
    }

    public int RemoveAt(int index)
    {
        ThrowExceptionIfIndexOutOfRange(index);

        int removedVariable = Items[index];
        ShiftLeft(index);
        Count--;

        if (Count <= Items.Length / 4)
        {
            Shrink();
        }

        Console.WriteLine($"You successfully removed the value at index {index}!");
        return removedVariable;
    }

    public void Swap(int indexOne, int indexTwo)
    {
        ThrowExceptionIfIndexOutOfRange(indexOne);
        ThrowExceptionIfIndexOutOfRange(indexTwo);

        int value = Items[indexOne];
        Items[indexOne] = Items[indexTwo];
        Items[indexTwo] = value;

        Console.WriteLine($"You successfully swapped the values in indexes {indexOne} and {indexTwo}!");
    }

    public bool Contains(int value)
    {
        bool contains = false;

        for (int i = 0; i < Count; i++)
        {
            if (Items[i] == value)
            {
                contains = true;
                break;
            }
        }
        if (contains)
        {
            Console.WriteLine($"The current list contains this value!");
        }
        else
        {
            Console.WriteLine($"The current list does not contain this value.");
        }
        return contains;
    }

    public void Print()
    {
        for (int i = 0; i < Count-1; i++)
        {
            Console.Write(Items[i] + ", ");
        }
        Console.WriteLine(Items[Count-1]);
    }

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

    private void ThrowExceptionIfIndexOutOfRange(int index)
    {
        if (index < 0 || index >= Count)
        {
            throw new IndexOutOfRangeException("Index is invalid!");
        }
    }

    private void ShiftLeft(int index)
    {
        for (int i = index; i < Count; i++)
        {
            Items[i] = Items[i+1];
        }
    }

    private void ShiftRight(int index)
    {
        for (int i = Count; i > index; i--)
        {
            Items[i] = Items[i-1];
        }
    }
}