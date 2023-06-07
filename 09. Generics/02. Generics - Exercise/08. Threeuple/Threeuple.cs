namespace Threeuple;

internal class Threeuple<T1, T2, T3>
{
    private T1 ItemOne { get; set; }
    private T2 ItemTwo { get; set; }
    private T3 ItemThree { get; set; }

    //Constructor
    public Threeuple(T1 itemOne, T2 itemTwo, T3 itemThree)
    {
        ItemOne = itemOne;
        ItemTwo = itemTwo;
        ItemThree = itemThree;
    }

    //Method
    public override string ToString()
    {
        return $"{ItemOne} -> {ItemTwo} -> {ItemThree}";
    }
}
