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
            if (number < 0) throw new ArgumentOutOfRangeException("Number must be positive");

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
    }
}
