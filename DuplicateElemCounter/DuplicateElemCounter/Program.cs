using System;
using System.Linq;
using System.Collections.Generic;

namespace DuplicateElemCounter
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a method which takes a string and returns an array of duplicate characters e.g. "Nishant Mandal" => (a,n)

            //string testString = "Nishant Mandal";
            string testString = "Nanananananananana Batman";
            //string testString = "";


            Console.WriteLine(DupicateCounter(testString));

        }


        public static char[] DupicateCounter(string testString)
        {

            if (testString.Length <= 0) 
            {
                throw new ArgumentOutOfRangeException("Give me something to do!");
            }

            var testStr = testString.ToLower();
            string recurringCharString = "";
            string dumpString = "";

            List<char> recurringCharactersList = new List<char>();

            foreach ( var singleChar in testStr)
            {
                if (!recurringCharactersList.Contains(singleChar))
                {
                    recurringCharactersList.Add(singleChar);
                }
                else
                {
                    if (!recurringCharString.Contains(singleChar) && singleChar != ' ')
                    {
                        recurringCharString += singleChar;
                    }
                    else
                    {
                        dumpString += singleChar;
                    }
                }
            }


            char[] ResultArray = recurringCharString.ToArray();
            return ResultArray;
        }


    }
}
