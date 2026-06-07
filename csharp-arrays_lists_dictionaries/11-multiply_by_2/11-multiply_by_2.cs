using System;
using System.Collections.Generic;

public class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        // Create a new dictionary to store the updated key-value pairs
        Dictionary<string, int> newDict = new Dictionary<string, int>();

        // Iterate through each key-value pair in the input dictionary
        foreach (KeyValuePair<string, int> entry in myDict)
        {
            // Multiply the value by 2 and add it to the new dictionary
            newDict[entry.Key] = entry.Value * 2;
        }

        // Return the new dictionary
        return newDict;
    }
}