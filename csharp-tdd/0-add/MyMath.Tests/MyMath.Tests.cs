using System;

namespace MyMath.Tests
{
    public class OperationsTests
    {
        public static void Main(string[] args)
        {
            TestPositiveIntegers();
            TestNegativeIntegers();
            TestPositiveAndNegative();
            TestAddZero();
            TestZeroPlusZero();
            TestRegularAddition();
            
            Console.WriteLine("All unit tests pass");
        }

        // <summary> Test for adding two positive integers </summary>
        public static void TestPositiveIntegers()
        {
            int result = Operations.Add(5, 3);
            if (result == 8)
                Console.WriteLine("Correct output: positive integers");
            else
                throw new Exception($"Test failed: expected 8, got {result}");
        }

        // <summary> Test for adding two negative integers </summary>
        public static void TestNegativeIntegers()
        {
            int result = Operations.Add(-5, -3);
            if (result == -8)
                Console.WriteLine("Correct output: negative integers");
            else
                throw new Exception($"Test failed: expected -8, got {result}");
        }

        // <summary> Test for adding a positive and a negative integer </summary>
        public static void TestPositiveAndNegative()
        {
            int result = Operations.Add(-10, 15);
            if (result == 5)
                Console.WriteLine("Correct output: positive + negative");
            else
                throw new Exception($"Test failed: expected 5, got {result}");
        }

        // <summary> Test for adding zero to a number </summary>
        public static void TestAddZero()
        {
            int result = Operations.Add(0, 42);
            if (result == 42)
                Console.WriteLine("Correct output: Add zero");
            else
                throw new Exception($"Test failed: expected 42, got {result}");
        }

        // <summary> Test for adding zero to zero </summary>
        public static void TestZeroPlusZero()
        {
            int result = Operations.Add(0, 0);
            if (result == 0)
                Console.WriteLine("Correct output: 0 + 0");
            else
                throw new Exception($"Test failed: expected 0, got {result}");
        }

        // <summary> Test for regular addition </summary>
        public static void TestRegularAddition()
        {
            int result = Operations.Add(10, 20);
            if (result == 30)
                Console.WriteLine("Test present: regular addition");
            else
                throw new Exception($"Test failed: expected 30, got {result}");
        }
    }
}