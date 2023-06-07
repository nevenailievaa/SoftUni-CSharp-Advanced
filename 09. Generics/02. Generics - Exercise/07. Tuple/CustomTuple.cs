namespace Tuple;

internal class CustomTuple<T1, T2>
{
    private T1 ItemOne { get; set; }
    private T2 ItemTwo { get; set; }

    //Constructor
    public CustomTuple(T1 itemOne, T2 itemTwo)
    {
        ItemOne = itemOne;
        ItemTwo = itemTwo;
    }

    //Method
    public override string ToString()
    {
        return $"{ItemOne} -> {ItemTwo}";
    }
}
