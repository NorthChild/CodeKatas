using System;
using System.Collections;

namespace TakeAStringAndReverseIt
{
    public class Program
    {
        static void Main(string[] args)
        {

            var testString = "This is my string";

            Console.WriteLine(TakeStringAndReverseIt(testString));
        }

        public static string TakeStringAndReverseIt(string testString)
        {

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
    }
}
