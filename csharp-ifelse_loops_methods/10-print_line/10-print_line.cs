using System;

class Program
{
    static void PrintLine(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write("_");
        }
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        Line.PrintLine(3);
        Line.PrintLine(0);
        Line.PrintLine(12);
        Line.PrintLine(-98);
    }
}