using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnFibonacciSum
{
    public class Class1
    {
        public static int FibonacciSumOfIntsNthIncludedLITE(int number)
        {

            if (number == 0) return 0;
            if (number < 0) throw new Exception("Number must be positive");

            int result = 0;
            int a = 0;
            int b = 1;
            int c;
            
            while (b <= number)
            {
                result += b;
                c = a + b;
                a = b;
                b = c;
            }
            return result;
        }

        public static int FibonacciSumOfIntsNthIncludedRecursion(int number)
        {

            if (number <= 0)
            {
                Console.WriteLine("Number must be positive!");
            }
            else if (number == 1)
            {
                return 1;
            }
            else if (number == 2)
            {
                return 1; 
            }
            else
            {
                return FibonacciSumOfIntsNthIncludedRecursion(number - 1) + FibonacciSumOfIntsNthIncludedRecursion(number - 2);
            }

            return 0;
        }
    }
}
