Using System;

class Array
{
    
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
       
        Console.WriteLine(array);
        array[index] = n;
        Console.WriteLine(array);

    }

}