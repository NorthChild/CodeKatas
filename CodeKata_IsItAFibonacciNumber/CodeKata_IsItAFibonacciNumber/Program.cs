using System;

namespace CodeKata_IsItAFibonacciNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsItPartOfFibonacci(5));
        }

        public static string IsItPartOfFibonacci(int numb)
        {

            if (numb < 0) throw new ArgumentOutOfRangeException("Int must be positive");

            if (IsItAPerfectSquare(5 * numb * numb + 4) || IsItAPerfectSquare(5 * numb * numb - 4))
            {
                return $"{numb} is part of Fibonacci";
            }

            return $"{numb} is not part of Fibonacci";
        }


        public static bool IsItAPerfectSquare(int numb)
        {
            int s = (int)Math.Sqrt(numb);
            return (s * s == numb);
        }



    }
}
