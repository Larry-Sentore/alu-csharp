Using System;

class Array
{
    
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        if (index < 0 || index >= array.Length)
        {
            return -1;
        
        }else{
       
            Console.WriteLine(array);
            array[index] = n;
            return array;
        }

    }

}