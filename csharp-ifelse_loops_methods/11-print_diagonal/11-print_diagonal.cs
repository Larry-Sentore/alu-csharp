using System;

class ExecutePrintDiagonal
{
    static void PrintDiagonal(int n)
    {
        if (n <= 0)
        {
            Console.WriteLine();
            return;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("\\");
        }
    }
    static void Main(string[] args)
    {
        Line.PrintDiagonal(3);
        Line.PrintDiagonal(0);
        Line.PrintDiagonal(12);
        Line.PrintDiagonal(-98);
    }
}