using System;
using System.Linq;

namespace CreateTestsForGivenMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = { 2, 3, 1, 7, 9, 5, 11, 3, 5 };

            Console.WriteLine($"Original array: {String.Join(", ", numArray)}");

            Console.WriteLine($"The maximum difference between two elements of the given array is : " +
                $"{DiffBetweenTwoElements(numArray)}");
        }
        public static int DiffBetweenTwoElements(int[] nums)
        {

            if (nums.Length == 0) throw new ArgumentOutOfRangeException("array is empty!");

            // This method takes an Int Array and returns the MAX-imum difference between the contents of the array
            // In the example array above the out will be as follows:
            // Original array: 2, 3, 1, 7, 9, 5, 11, 3, 5
            // The maximum difference between two elements of the given array is : 10

            var orderedList = nums.OrderBy(c => c);

            var lowest = orderedList.FirstOrDefault();
            var highest = orderedList.Last();

            return highest - lowest;

        }
    }
}
