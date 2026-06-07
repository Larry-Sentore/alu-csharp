using System;
using System.Collections.Generic;

public class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int count = 0;

        
        foreach (int _ in myLList)
        {
            count++;
        }

        return count;
    }
}
