using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

//INPUT
string[] songs = Console.ReadLine().Split(", ").ToArray();

//ACTION
Queue<string> songsQueue = new Queue<string>(songs);

while (songsQueue.Count >= 0)
{
    string[] command = Console.ReadLine().Split().ToArray();

	if (command[0] == "Play")
	{
        if (songsQueue.Count > 0)
        {
            songsQueue.Dequeue();

            if (songsQueue.Count == 0)
            {
                Console.WriteLine("No more songs!");
                return;
            }
        }
    }
	else if (command[0] == "Add")
    {
        string songName = String.Join(" ", command.Skip(1));

        if (songsQueue.Contains(songName))
        {
            Console.WriteLine($"{songName} is already contained!");
        }
        else
        {
            songsQueue.Enqueue(songName);
        }
    }
    else if (command[0] == "Show")
    {
        Console.WriteLine(String.Join(", ", songsQueue));
    }
}