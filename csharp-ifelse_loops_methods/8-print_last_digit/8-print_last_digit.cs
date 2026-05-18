using System;

class Program
{
    static int PrintLastDigit(int n)
    {
        int lastDigit = Math.Abs(n % 10);
        Console.WriteLine(lastDigit);
        return lastDigit;
    }
    
    static void Main(string[] args)
    {
        int r;

        Number.PrintLastDigit(98);
        Number.PrintLastDigit(0);
        r = Number.PrintLastDigit(-1024);
        Console.WriteLine(r);
    }
}
