using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeKata4_returnClosestToZero
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] testArray = new int[] { 9, 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine(GivenAnArrayReturnsClosestToZero(testArray));
        }

        

        public static int GivenAnArrayReturnsClosestToZero(int[] testArray)
        {

            CheckArrayEmptyOrOfLengthOf1(testArray);
            CheckArrayIsntFilledWithSingleValInts(testArray);

            int[] orderedArray = OrderAGivenArrayAndReturnIt(testArray);
            int[] orderedAndUniqueArray = RemoveDouplicatesFromGivenArrayAndReturnIt(orderedArray);

            if (orderedAndUniqueArray[0] == 0)
            {
                return orderedAndUniqueArray[1];
            }
            else
            {
                return orderedAndUniqueArray[0];
            }
        }


        public static int[] OrderAGivenArrayAndReturnIt(int[] testArray)
        {
            if (testArray.All(o => o < 0))
            {
                int[] orderedNegativeArray = testArray.OrderByDescending(c => c).ToArray();
                return orderedNegativeArray;
            }
            else
            {
                return testArray.OrderBy(c => c).ToArray();
            }
        }


        public static int[] RemoveDouplicatesFromGivenArrayAndReturnIt(int[] testArray)
        {

            int[] duplicateFreeArray = testArray.Distinct().ToArray();
            return duplicateFreeArray;
        }


        public static void CheckArrayIsntFilledWithSingleValInts(int[] testArray)
        {

            var assumedResultOfAllElementsIfArrayIsFullOfCopies = testArray[0] * testArray.Length;
            var actualResultOFAllElementsInArray = 0;

            foreach (var i in testArray)
            {
                actualResultOFAllElementsInArray += i;
            }

            if (assumedResultOfAllElementsIfArrayIsFullOfCopies == actualResultOFAllElementsInArray)
            {
                throw new ArgumentException("Array is made of same integers, please provide variety");
            }
        }

        public static void CheckArrayEmptyOrOfLengthOf1(int[] testArray)
        {

            if(testArray.Length == 0)
            {
                throw new ArgumentException("Array cant be empty");
            }

            if (testArray.Length == 1)
            {
                throw new ArgumentException("Array needs to be greater that 1");
            }
        }
    }
}
