using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0)
        {
            return "None";
        }
        
        int maxScore = -1;
        string bestStudent = "";
        
        foreach (KeyValuePair<string, int> pair in myList)
        {
            if (pair.Value > maxScore)
            {
                maxScore = pair.Value;
                bestStudent = pair.Key;
            }
        }
        
        return bestStudent;
    }
}