using System;
using System.Collections.Generic;

public class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> linkedList = new LinkedList<int>();

        // Return an empty list if size is negative
        if (size < 0)
            return linkedList;

        for (int i = 0; i < size; i++)
        {
            linkedList.AddLast(i);
            Console.WriteLine(i);
        }

        return linkedList;
    }
}
