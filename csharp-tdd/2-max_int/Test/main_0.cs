using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> nums = new List<int>();
        foreach (string arg in args)
            nums.Add(int.Parse(arg));

        int result = MyMath.Operations.Max(nums);
        Console.WriteLine(result);
    }
}
