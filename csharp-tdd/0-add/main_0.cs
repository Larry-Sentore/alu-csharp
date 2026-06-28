/// <summary> Entry point for the MyMath addition program </summary>
using System;

/// <summary> Main program class </summary>
class Program
{
    /// <summary> Main method that demonstrates the Add operation </summary>
    static void Main(string[] args)
    {
        int a, b, result;

        a = 3;
        b = 4;
        result = MyMath.Operations.Add(a, b);
        Console.WriteLine("{0} + {1} = {2}", a, b, result);
    }
}
