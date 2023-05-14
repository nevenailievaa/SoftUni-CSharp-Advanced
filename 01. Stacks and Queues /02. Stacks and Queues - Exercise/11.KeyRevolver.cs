using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

//INPUT
int bulletPrice = int.Parse(Console.ReadLine());
int gunBarrelSize = int.Parse(Console.ReadLine());
int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
int intelligenceValue = int.Parse(Console.ReadLine());

//ACTION
Queue<int> locksQueue = new Queue<int>(locks);
Stack<int> bulletsStack = new Stack<int>(bullets);

int spentMoney = 0;
int shotsCounter = 0;
int barrelCounter = 0;

while (bulletsStack.Count > 0 && locksQueue.Count > 0)
{
    for (int i = 1; i <= gunBarrelSize; i++)
    {
        if (i == 1)
        {
            barrelCounter = 0;
        }
        if (bulletsStack.Count == 0 && locksQueue.Count > 0)
        {
            Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
            return;
        }
        else
        {
            if (locksQueue.Count > 0)
            {
                int currentBullet = bulletsStack.Pop();
                int currentLock = locksQueue.Peek();
                shotsCounter++;
                barrelCounter++;

                if (currentBullet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                    locksQueue.Dequeue();

                    spentMoney += bulletPrice;
                }
                else
                {
                    Console.WriteLine("Ping!");
                    spentMoney += bulletPrice;
                }
            }
        }
    }
    if (bulletsStack.Count > 0 && barrelCounter == gunBarrelSize)
    {
        Console.WriteLine("Reloading!");
    }
}

//OUTPUT
if (bulletsStack.Count >= 0 && locksQueue.Count == 0)
{
    Console.WriteLine($"{bulletsStack.Count} bullets left. Earned ${intelligenceValue - spentMoney}");
}
else if (locksQueue.Count > 0)
{
    Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
}