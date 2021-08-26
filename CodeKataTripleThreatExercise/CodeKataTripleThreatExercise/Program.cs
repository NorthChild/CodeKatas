using System;
using System.Linq;
using System.Collections.Generic;

namespace CodeKataTripleThreatExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            // 1 
            //Console.WriteLine("What conversion type would you like to apply? (FAHRENHEIT / CELSIUS)");
            //var conversionToApply = Console.ReadLine().ToUpper();
            //Console.WriteLine($"What temperature would you like to convert to {conversionToApply}");
            //var tempToConvert = Console.ReadLine();
            //Console.WriteLine(TemperatureConverter(conversionToApply, tempToConvert));


            // 2
            //Console.WriteLine("Give me numbers and i shall give you their average! (separate Nums with a space)");
            //string intsToAvgInStringFormat = Console.ReadLine();
            //Console.WriteLine(FromCommandLineTakeIntsAndReturnAverage(intsToAvgInStringFormat));


            // 3
            Console.WriteLine("CharIdentifier");
            
            bool running = true;

            while (running)
            {
                string charToIdentify = Console.ReadLine();
                CharacterIdentifier(charToIdentify);

                if (charToIdentify.Contains("#"))
                {
                    running = false;
                }
            }
            
            
        }


        // ########################################################################################################################################## //
        public static double TemperatureConverter(string conversionToApply, string tempToConvert)
        {
            // 1
            // Create a program that converts a temperature into Celsius or Fahrenheit. 
            // First prompt will ask for the conversion type(Fahrenheit or Celsius), the second will ask for the Temperature.
            // F => C :     (F - 32) * 5/9
            // C => F :     (C * 9/5) + 32

            double temp = Convert.ToDouble(tempToConvert);

            if (conversionToApply != "CELSIUS" && conversionToApply != "FAHRENHEIT") throw new ArgumentException("INVALID CONVERSION");

            double result = 0;

            if (conversionToApply == "CELSIUS") 
            {
                result = (temp - 32) * 5 / 9;
            }
            else if (conversionToApply == "FAHRENHEIT")
            {
                result = (temp * 9 / 5) + 32;
            }

            return result;
        }


        // ########################################################################################################################################## //
        public static string FromCommandLineTakeIntsAndReturnAverage(string testString)
        {
            // 2
            // Create a program that will behave as follows from the command line:
            //      c:/>AverageMarks 2 100 50
            //      c:/>Average marks of (2,100,50) = 50.666666666666664

            bool success;

            
            Console.WriteLine($"AverageMarks {testString}");
            
            List<string> arryOfInts = new List<string>();

            foreach (var i in testString.Split(" "))
            {
                arryOfInts.Add(i);
            }

            //
            foreach (var i in arryOfInts)
            {
                long dump = 0;
                bool testChar = Int64.TryParse(i, out dump);
                
                if (testChar == false)
                {
                    throw new ArgumentOutOfRangeException("INSERT ONLY NUMBERS!");
                }

            }

            //
            string allMarksInStringFinal = "(";
            foreach (var i in arryOfInts)
            {
                if (i != arryOfInts.Last())
                {
                    allMarksInStringFinal += $"{i},";
                }
            }
            allMarksInStringFinal += $"{arryOfInts.Last()})";

            //
            List<int> intsToConvert = new List<int>();

            foreach(var i in arryOfInts)
            {
                intsToConvert.Add(Convert.ToInt32(i));
            }

            var result = intsToConvert.Average();   
            return $"Average marks of {allMarksInStringFinal} = {result}";

        }


        // ########################################################################################################################################## //
        public static string CharacterIdentifier(string charToIdentify)
        {
            // 3 
            //Create a program that will behave as follows from the command line:
            //      c:/> CharIdentifier
            //      c:/> a
            //      c:/> Entered character a is Vowel
            //      c:/> L
            //      c:/> Entered character L is Consonant
            //      c:/>#
            //      c:/> Goodbye

            long dump = 0;
            bool testChar = Int64.TryParse(charToIdentify, out dump);

            if (testChar == true)
            {
                throw new ArgumentOutOfRangeException("ONLY WORKS WITH LETTERS, SOZ");
            }

            if (charToIdentify.Length > 1)
            {
                throw new ArgumentOutOfRangeException("ONLY SINGLE CHARACTERS PLEASE!");
            }

            if (charToIdentify.ToUpper().Contains('A') || charToIdentify.ToUpper().Contains('E') || charToIdentify.ToUpper().Contains('I') || charToIdentify.ToUpper().Contains('O') || charToIdentify.ToUpper().Contains('U'))
            {
                Console.WriteLine($"Entered character {charToIdentify} is Vowel");
                return $"Entered character {charToIdentify} is Vowel";
            }
            else if (charToIdentify.Contains("#"))
            {
                Console.WriteLine("Goodbye");
                return "Goodbye";
            }
            else
            {
                Console.WriteLine($"Entered character {charToIdentify} is Consonant");
                return $"Entered character {charToIdentify} is Consonant";
            }

            //return " ";
        }



    }
}
