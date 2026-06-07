using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (myLList == null || myLList.First == null || index < 0)
            return;

        LinkedListNode<int> current = myLList.First;
        int count = 0;

        
        if (index == 0)
        {
            myLList.RemoveFirst();
            return;
        }

        
        while (current != null && count < index - 1)
        {
            current = current.Next;
            count++;
        }

        
        if (current != null && current.Next != null)
        {
            myLList.Remove(current.Next);
        }
    }
}
