using System;

class Program
{
    static void Main(string[] args)
    {
        string input = args[0];
        if (Text.Str.IsPalindrome(input))
            Console.WriteLine($"{input} is a palindrome");
        else
            Console.WriteLine($"{input} is not a palindrome");
    }
}
