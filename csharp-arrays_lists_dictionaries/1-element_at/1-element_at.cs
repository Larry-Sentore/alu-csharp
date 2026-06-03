using System;

class Array
{
    
    public static int elementAt(int[] array, int index)
    {
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Index is out of range");
            return -1;
        }else
        {
            Console.WriteLine("Element at index {0} is {1}", index, array[index]);
            return array[index];
        }
    }

}