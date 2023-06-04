namespace CustomDoublyLinkedList;

public class Node
{
    public int Value { get; set; }
    public Node Next { get; set; }
    public Node Previous { get; set; }

    //Constructor
    public Node(int value, Node next = null, Node previous = null)
    {
        Value = value;
        Next = next;
        Previous = previous;
    }
}
