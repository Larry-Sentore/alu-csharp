using System;
using System.Collections.Generic;

public class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        // Create a new list to store the results
        List<bool> result = new List<bool>();

        // Iterate through the list and check if each element is divisible by 2
        foreach (int num in myList)
        {
            if (num % 2 == 0)
            {
                result.Add(true);
            }
            else
            {
                result.Add(false);
            }
        }

        return result;
    }
}