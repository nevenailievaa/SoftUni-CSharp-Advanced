using System;
using System.Data;
using CustomDoublyLinkedList;

//Creating Doubly Linked List
SoftuniLinkedList numbers = new SoftuniLinkedList();

//Testing
string command = string.Empty;

while ((command = Console.ReadLine()) != "End")
{
    string[] commandInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

    string typeCommand = commandInfo[0];

    //Add First
    if (typeCommand == "AddFirst")
    {
        int element = int.Parse(commandInfo[1]);
        numbers.AddFirst(element);
    }

    //Add Last
    else if (typeCommand == "AddLast")
    {
        int element = int.Parse(commandInfo[1]);
        numbers.AddLast(element);
    }

    //Remove First
    else if (typeCommand == "RemoveFirst")
    {
        numbers.RemoveFirst();
    }

    //Remove Last
    else if (typeCommand == "RemoveLast")
    {
        numbers.RemoveLast();
    }

    //ForEach
    else if (typeCommand == "ForEach")
    {
        Func<int, int> action = new Func<int, int>(n => n*2);
        numbers.ForEach(action);
    }

    //ToArray
    else if (typeCommand == "ToArray")
    {
        numbers.ToArray();
    }
}
