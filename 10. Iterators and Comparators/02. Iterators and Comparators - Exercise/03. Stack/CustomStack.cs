using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace CustomStack;

public class CustomStack<T> : IEnumerable<T>
{
    //Constructor
    public CustomStack()
    {
        Items = new List<T>();
        Counter = 0;
    }

    //Properties
    private List<T> Items { get; set; }
    public int Counter { get; private set; }

    //Methods
    public void Push(T value)
    {
        Items.Add(value);
        Counter++;
    }
    public T Pop()
    {
        T value = Items[Items.Count-1];
        Items.RemoveAt(Items.Count-1);
        Counter--;
        return value;
    }

    //IEnumerable Methods
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = Items.Count-1; i >= 0; i--)
        {
            yield return Items[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

