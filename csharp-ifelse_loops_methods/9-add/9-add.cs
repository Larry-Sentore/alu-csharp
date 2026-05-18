using System;

class Program
{
    static int Add(int a, int b)
    {
        return a + b;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("{0}", Number.Add(1, 2));
        Console.WriteLine("{0}", Number.Add(98, 0));
        Console.WriteLine("{0}", Number.Add(100, -2));
    }
}