using System;
using System.Linq;

namespace CodeKata3_GroupedByCommas
{
    public class Program
    {
        static void Main(string[] args)
        {

            var testInt = -123456789;

            Console.WriteLine(GroupByMethod(testInt));
        }

        public static string GroupByMethod(int n)
        {

            if (n.ToString().Length < 3)
            {
                return n.ToString();
            }

            string convertedIntToString = ReturnIntToStringVal(n);
            string reversedString = ReverseTheIntReadyForCommas(convertedIntToString);
            string addedCommasToReversedString = ReturnIntGroupedWithCommas(reversedString);
            string correctOrderAndGroupedRes = ReturnReReversedStringWithCommas(addedCommasToReversedString);
            
            return correctOrderAndGroupedRes;
        }

        public static string ReturnIntToStringVal(int n)
        {
            string intToString = "";
            intToString = n.ToString(intToString);

            return intToString;

        }

        public static string ReverseTheIntReadyForCommas(string n)
        {
            var resultString = n.Reverse().ToArray();
            var resString = "";

            foreach (var i in resultString) resString += i;

            return resString;
        }

        public static string ReturnIntGroupedWithCommas(string n)
        {
            string groupedWithCommas = "";
            var counter = 0;

            for (var i = 0; i < n.Length; i++)
            {

                groupedWithCommas += n[i];
                counter++;

                if (counter == 3 && n[i] !=n.Last())
                {
                    groupedWithCommas += ",";
                    counter = 0;
                }
            }

            return groupedWithCommas;
        }

        public static string ReturnReReversedStringWithCommas(string n)
        {
            var groupedWithCommasOrdered = n.Reverse().ToArray();
            var resString = "";

            foreach (var i in groupedWithCommasOrdered) resString += i;

            if (resString.ElementAt(1) == ',' && resString.ElementAt(0) == '-')
            {
                var polishedString = resString.Remove(1, 1);
                return polishedString;
            }
            else
            {
                return resString;
            }
        }

        


    }
}
