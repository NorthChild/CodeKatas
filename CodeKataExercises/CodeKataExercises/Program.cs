using System;

namespace CodeKataExercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Hello to my Code Kata Exercises");
            Console.WriteLine("-------------------------------");


            // 1
            // return largest of array
            int[] testArray1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 89 };
            //int[] testArray1 = new int[] { -1, -2, -3, -4, -5, -6, -7, -89 };
            Console.WriteLine(CheckLargestOfTheGivenNumbers(testArray1));

            // 2
            // Write a program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies


            // 3


            // 4


            // 5 


        }


        static public int CheckLargestOfTheGivenNumbers(int[] arrayToCheck)
        {

            var result = arrayToCheck[0];

            for (var i = 0; i <= arrayToCheck.Length; i++)
            {
                var pointer = arrayToCheck[i];

                if (pointer > result)
                {
                    result = pointer;
                }
            }
            
            
            
            return result;
        }



    }
}
