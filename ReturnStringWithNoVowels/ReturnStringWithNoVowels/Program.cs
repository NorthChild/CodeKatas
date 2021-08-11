﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace ReturnStringWithNoVowels
{
    public class Program
    {
        static void Main(string[] args)
        {
            // write a method, takes a string and remove the vowels and return the string without the vowels 

            var testString = "i am a test string, i dont have much to say about myself, being a string is hard!";


            Console.WriteLine(Disemvowelling(testString));
        }


        public static string Disemvowelling(string stringToCheck) 
        {

            var loweredString = stringToCheck.ToLower();

            var disemvowelledString = "";

            foreach (var element in loweredString)
            {
                if (!element.Equals('a') && !element.Equals('e') && !element.Equals('i') && !element.Equals('o') && !element.Equals('u'))
                {
                    disemvowelledString += element;
                }
            }

            

            return disemvowelledString;
        }




    }
}
