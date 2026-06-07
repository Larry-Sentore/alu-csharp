using System;
using System.Collections.Generic;

public class List
{
    public static int Sum(List<int> myList)
    {
        HashSet<int> numberUNique = new HashSet<int>(myList);
        int sum = 0;
        

        foreach (int num in numberUNique)
        {
            sum += num;
        }

        return sum;
    }
}
