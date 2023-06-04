namespace CustomDoublyLinkedList;

public class SoftuniLinkedList
{
    public Node Head { get; set; }
    public Node Tail { get; set; }
    public int Count { get; set; }

    //Constructor
    public SoftuniLinkedList(Node head = null, Node tail = null)
    {
        Head = head;
        Tail = tail;
    }

    //Adding First Method
    public void AddFirst(int element)
    {
        Node node = new Node(element);

        if (Head == null && Tail == null)
        {
            Head = node;
            Tail = node;
        }
        else
        {
            Head.Previous = node;
            node.Next = Head;
            Head = node;
        }

        Console.WriteLine($"Successfully added {element} on first position.");
        Count++;
    }

    //Adding Last Method
    public void AddLast(int element)
    {
        Node node = new Node(element);

        if (Head == null && Tail == null)
        {
            Head = node;
            Tail = node;
        }
        else
        {
            Tail.Next = node;
            node.Previous = Tail;
            Tail = node;
        }

        Console.WriteLine($"Successfully added {element} on last position.");
        Count++;
    }

    //Removing First Method
    public void RemoveFirst()
    {
        if (Head == null && Tail == null)
        {
            throw new ArgumentException("The list is empty!");
        }
        else
        {
            Node previousHead = Head;
            Head = previousHead.Next;
            Head.Previous = null;
            previousHead.Next = null;

            //OUTPUT
            Console.WriteLine($"You successfully removed the head ({previousHead.Value})!");
            if (Head != null)
            {
                Console.WriteLine($"Current Head: {Head.Value}.");
            }
            else
            {
                Console.WriteLine($"No more numbers!");
            }
        }
    }

    //Removing Last Method
    public void RemoveLast()
    {
        if (Head == null && Tail == null)
        {
            throw new ArgumentException("The list is empty!");
        }
        else
        {
            Node previousTail = Tail;
            Tail = previousTail.Previous;
            Tail.Next = null;
            previousTail.Previous = null;

            //OUTPUT
            Console.WriteLine($"You successfully removed the tail! ({previousTail.Value})");
            if (Tail != null)
            {
                Console.WriteLine($"Current Tail: {Tail.Value}.");
            }
            else
            {
                Console.WriteLine($"No more numbers!");
            }
        }
    }

    //ForEach Method
    public void ForEach(Func<int, int> action)
    {
        Node currentNode = Head;

        while (currentNode != null)
        {
            currentNode.Value = action(currentNode.Value);

            if (currentNode.Next != null)
            {
                Console.Write(currentNode.Value + ", ");
                currentNode = currentNode.Next;
            }
            else
            {
                Console.WriteLine(currentNode.Value);
                break;
            }
        }
    }

    //ToArray Method
    public void ToArray()
    {
        Node currentNode = Head;
        int[] nodesArray = new int[Count];

        int counter = 0;

        while (currentNode != null)
        {
            nodesArray[counter] = currentNode.Value;
            currentNode = currentNode.Next;
            counter++;
        }

        Console.WriteLine("Successfully turned your nodes into node array:");
        Console.WriteLine(String.Join(", ", nodesArray));
    }
}
