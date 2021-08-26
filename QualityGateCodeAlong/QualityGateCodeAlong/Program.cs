using System;
using System.Collections.Generic;
using System.Linq;

namespace QualityGateCodeAlong
{
    public class Program
    {
        static void Main(string[] args)
        {
            var stringToTest = "Hello";

            Console.WriteLine(ReturnDuplicatesFromString(stringToTest));
        }

        public static char[] ReturnDuplicatesFromString(string stringToTest)
        {
            if (stringToTest.Length < 1)
            {
                throw new ArgumentOutOfRangeException("array is empty");
            }

            List<char> listToPop = new List<char>();
            List<char> listOfDups = new List<char>();

            foreach (var i in stringToTest)
            {
                if (!listToPop.Contains(i)) 
                {
                    listToPop.Add(i);
                }
                else
                {
                    // this came to mind after the code along 
                    // added later
                    if (!listOfDups.Contains(i))
                    {
                        listOfDups.Add(i);
                    }
                    
                }
            }

            return listOfDups.ToArray();
        }


    }
}
