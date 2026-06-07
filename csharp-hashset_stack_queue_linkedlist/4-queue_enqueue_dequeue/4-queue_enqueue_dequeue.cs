using System;
using System.Collections.Generic;

public class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine("Number of items: " + aQueue.Count);

        if (aQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Console.WriteLine("First item: " + aQueue.Peek());
        }

        aQueue.Enqueue(newItem);

        bool containsSearch = aQueue.Contains(search);
        Console.WriteLine($"Queue contains \"{search}\": {containsSearch}");

         if (containsSearch)
        {
            Queue<string> tempQueue = new Queue<string>();

            string current;
            do
            {
                current = aQueue.Dequeue();
            } while (current != search);

        }

        return aQueue;
    }
}
