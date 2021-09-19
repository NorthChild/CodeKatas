using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CodeKata4_returnClosestToZero;

namespace TestingCodeKata4.Happy_Path
{
    public class WhenMethodReceivesArrayItReturnsNumbClosestToZero
    {


        [Test]
        public void WhenMethodReceivesArrayOfPositiveNumbers_RetreiveClosestToZero()
        {
            int[] testArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var result = 1;

            Assert.That(() => Program.GivenAnArrayReturnsClosestToZero(testArray), Is.EqualTo(result));
        }

        [Test]
        public void WhenMethodReceivesArrayOfPositiveNumbersWithAZero_RetreiveClosestToZero()
        {
            int[] testArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var result = 1;

            Assert.That(() => Program.GivenAnArrayReturnsClosestToZero(testArray), Is.EqualTo(result));
        }

        [Test]
        public void WhenMethodReceivesArrayOfNumbersWithDouplicate_RemoveDouplicateIntsAndRetreiveClosestToZero()
        {
            int[] testArray = new int[] { 1, 1, 2, 3, 3, 4, 5, 6, 7, 8, 9 };
            var result = 1;

            Assert.That(() => Program.GivenAnArrayReturnsClosestToZero(testArray), Is.EqualTo(result));
        }


        [Test]
        public void WhenMethodReceivesArrayOfNegativeNumbers_RetreiveClosestToZero()
        {
            int[] testArray = new int[] { -1, -2, -3, -4, -5, -6, -7, -8, -9 };
            var result = -1;

            Assert.That(() => Program.GivenAnArrayReturnsClosestToZero(testArray), Is.EqualTo(result));
        }






    }
}
