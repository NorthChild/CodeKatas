using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeAlongTest_TrainerNishant
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Nish!");
            // create a method which takes an array of int and returns the second highest int in the array

    
            int[] arrayToTest = new int[] { 1, 2, 3, 3, 4, 5, 6, 7, 3, 7, 7 };

            Console.WriteLine(Return2ndHighest(arrayToTest));
        }

        public static int Return2ndHighest(int[] array)
        {


            if (array.Length == 0)
            {
                throw new ArgumentOutOfRangeException("Mmmmh this array seems to be empty");
            }

            // create a new list that will store only the non-repeting elements of the original list
            List<int> noDuplicates = new List<int>();

            // check for dublicates from original list, unique ints will be placed in the list we created
            for (var i = 0; i < array.Length; i++)
            {

                if (!noDuplicates.Contains(array[i]))
                {
                    noDuplicates.Add(array[i]);
                }

            }

            // we order the list of unique ints in descending order,
            // this way we know that the the second element (index 1) will store the second highest value int 
            var result = noDuplicates.OrderByDescending(c => c);
            return result.ElementAt(1);
        }


    }
}
