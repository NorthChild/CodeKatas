using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeKata_HowManyLimbs
{

    public interface IMultiLimb
    {
        public string Name { get; set; }
        public int NumberOfLimbs { get; set; }
    }
    public class Animal : IMultiLimb
    {
        public string Name { get; set; }
        public int NumberOfLimbs { get; set; }
    }
    public class Alien : IMultiLimb
    {
        public string Name { get; set; }
        public int NumberOfLimbs { get; set; }
    }

    public class SortedByLimbs
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static List<IMultiLimb> Sort<T>(List<IMultiLimb> list) where T : IMultiLimb
        {
            return list.OrderByDescending(o => o.NumberOfLimbs).ToList();
        }
    }
}
