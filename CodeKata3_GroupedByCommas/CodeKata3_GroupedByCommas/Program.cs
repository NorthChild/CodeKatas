using System;

namespace CodeKata3_GroupedByCommas
{
    public class Program
    {
        static void Main(string[] args)
        {

            var testInt = 123;

            Console.WriteLine(GroupByMethod(testInt));

        }

        public static string GroupByMethod(int n)
        {
            var result = ReturnIntGroupedWithCommas(n);
            return result;
        }


        public static string ReturnIntGroupedWithCommas(int n)
        {
            return "ready";
        }


    }
}
