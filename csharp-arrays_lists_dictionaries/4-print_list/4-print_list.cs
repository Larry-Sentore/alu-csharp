﻿﻿using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        List<int> result = new List<int>();

        for (int i = 0; i < size; i++)
        {
            result.Add(i);
        }

        for (int i = 0; i < result.Count; i++)
        {
            Console.Write(result[i]);
            
            if (i < result.Count - 1)
                Console.Write(" ");
        }
        
        Console.WriteLine();

        return result;
    }
}