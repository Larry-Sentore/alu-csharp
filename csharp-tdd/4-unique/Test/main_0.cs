using System;

class Program
{
    static void Main(string[] args)
    {
        string input = args[0];
        int result = Text.Str.UniqueChar(input);
        Console.WriteLine(result);
    }
}
