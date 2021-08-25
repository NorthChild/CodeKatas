using System;
using System.Collections;

namespace TakeAStringAndReverseIt
{
    public class Program
    {
        static void Main(string[] args)
        {

            //var testString = "This is my string";

            Console.WriteLine("Insert a string to reverse: ");
            var testString = Console.ReadLine();
            Console.WriteLine();

            // method 1: using stack
            Console.WriteLine($"Using stack: {TakeStringAndReverseIt(testString)}");
            // method 2: using for loop
            Console.WriteLine($"Using for loop: {TakeAStringAndReverseItOtherMethod(testString)}");
        }

        public static string TakeStringAndReverseIt(string testString)
        {

            if (testString.Length == 0) throw new ArgumentOutOfRangeException("string is empty");
            if (testString.Length == 1) return testString;

            Stack reversedStringStack = new Stack();
            string stringResult = "";

            foreach (var i in testString)
            {
                reversedStringStack.Push(i);
            }
            foreach (var i in reversedStringStack)
            {
                stringResult += i;
            }
            return stringResult;
        }

        public static string TakeAStringAndReverseItOtherMethod(string testString)
        {

            if (testString.Length == 0) throw new ArgumentOutOfRangeException("string is empty");
            if (testString.Length == 1) return testString;

            int stringLen = testString.Length - 1;
            var resultString = "";

            for (int i = testString.Length - 1; i >= 0; i--)
            {
                resultString += testString[i];
            }
            return resultString;
        }
    }
}
