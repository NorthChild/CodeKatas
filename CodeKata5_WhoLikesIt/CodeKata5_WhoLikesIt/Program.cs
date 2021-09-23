using System;
using System.Linq;


namespace CodeKata5_WhoLikesIt
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] testArray = new string[] { };
            string[] testArrayI = new string[] { "Ben"};
            string[] testArrayII = new string[] { "Ben", "Sergio" };
            string[] testArrayIII = new string[] { "Ben", "1" };
            string[] testArrayIV = new string[] { "Ben", "X Æ A-12" };
            string[] testArrayV = new string[] { "Ben", "Sergio", "Snow" };
            string[] testArrayVI = new string[] { "Ben", "Sergio", "Snow", "Nish" };

            Console.WriteLine(LikeThis(testArray));
            Console.WriteLine(LikeThis(testArrayI));
            Console.WriteLine(LikeThis(testArrayII));
            Console.WriteLine(LikeThis(testArrayIII));
            Console.WriteLine(LikeThis(testArrayIV));
            Console.WriteLine(LikeThis(testArrayV));
            Console.WriteLine(LikeThis(testArrayVI));
        }

        public static string LikeThis(string[] testArray)
        {
            foreach( var i in testArray)
            {
                var isParsable = 0;
                var parsedElement = int.TryParse(i, out isParsable);
                
                if (parsedElement)
                {
                    throw new ArgumentOutOfRangeException("Array must contain names");
                }
            }

            switch (testArray.Length)
            {
                case 0:
                    return "no one likes this";
                case 1:
                    return $"{testArray[0]} likes this";
                case 2:
                    return $"{testArray[0]} and {testArray[1]} like this";
                case 3:
                    return $"{testArray[0]}, {testArray[1]} and {testArray[2]} like this";
                default:
                    return $"{testArray[0]}, {testArray[1]} and {testArray.Length - 2} others like this";
            }
        }
    }
}
