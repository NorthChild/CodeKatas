using System;



namespace ReturnFibonacciSum
{
    public class Program
    {


        public static void Main()
        {
            int number = 20;
            Console.WriteLine(FibonacciSumOfIntsNthIncluded(number));
            Console.WriteLine(Class1.FibonacciSumOfIntsNthIncludedLITE(number));
        }
        
        public static int FibonacciSumOfIntsNthIncluded(int number)
        {
            if (number == 0) return 0;
            if (number < 0) throw new Exception("Number must be positive");   
            
            // create the base to build upon 
            int result = 0;

            int a = 0;
            int b = 1;
            int c;

            // nth not included
            //while (b < number)
            //{

            //    result += b;
            //    c = a + b;
            //    a = b;
            //    b = c;
            //}

            // nth included
            while (b <= number)
            {

                // add the position we just passed 
                result += b;
                // calculate next position
                c = a + b;
                // shift to the next position 
                a = b;
                // b increases and then returns to be checked
                b = c;
            }
            return result;
        }

    }
}