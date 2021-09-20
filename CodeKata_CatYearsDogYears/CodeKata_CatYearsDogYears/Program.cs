using System;

namespace CodeKata_CatYearsDogYears
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var testIntAge = 1;
            GivenHumanAgeReturnCatDogAge(testIntAge);


        }

        public static int[] GivenHumanAgeReturnCatDogAge(int humanYears)
        {
            return (humanYears == 1) ? new int[] { 1, 15, 15 } 
            : (humanYears == 2) ? new int[] { 2, 24, 24 } 
            : (humanYears > 2) ? new int[] { humanYears, ((humanYears - 2) * 4 + 24), ((humanYears - 2) * 5 + 24) } 
            : new int[] { 0, 0, 0 };

        }




    }
}
