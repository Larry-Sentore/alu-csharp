using System;
using System.Collections.Generic;

public class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        // Check if the key exists and either add or update the value
        if (myDict.ContainsKey(key))
        {
            myDict[key] = value; // Replace the value for the existing key
        }
        else
        {
            myDict.Add(key, value); // Add the new key-value pair
        }

        return myDict; // Return the updated dictionary
    }
}