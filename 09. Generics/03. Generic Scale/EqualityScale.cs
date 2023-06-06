namespace GenericScale;

public class EqualityScale<T> where T : IComparable<T>
{
    private T Left;
    private T Right;

    //Constructor
    public EqualityScale(T left, T right)
    {
        Left = left;
        Right = right;
    }

    public bool AreEqual()
    {
        return Left.Equals(Right);
    }
}
