using System;
using System.Collections.Generic;

public class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int keyCount = 0;

        // Iterate through the dictionary keys and count them
        foreach (var key in myDict.Keys)
        {
            keyCount++;
        }

        return keyCount;
    }
}