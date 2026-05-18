using System

class Program
{
    static void Main()
    {
        PrintAlphabet();
    }

    static void PrintAlphabet()
    {
        for (char letter = 'a'; letter <= 'z'; letter++)
        {
            Console.Write(letter);
        }
    }
}