using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CodeKata4_returnClosestToZero;

namespace TestingCodeKata4.Happy_Path
{
    public class WhenMethodReceivesInvalidInputReturnsVariousExceptions
    {
        
        [Test]
        public void WhenMethodReceivesArrayOfLengthOf1_ThrowException()
        {
            int[] testArray = new int[] { 9 };

            Assert.That(() => Program.GivenAnArrayReturnsClosestToZero(testArray), Throws.TypeOf<ArgumentException>().With.Message.Contains("Array needs to be greater that 1"));
        }


        [Test]
        public void WhenMethodReceivesAnEmptyArray_ThrowException()
        {
            int[] testArray = new int[] { };

            Assert.That(() => Program.GivenAnArrayReturnsClosestToZero(testArray), Throws.TypeOf<ArgumentException>().With.Message.Contains("Array cant be empty"));
        }


        [Test]
        public void WhenMethodReceivesAnArrayOfOnlyManyOfASingleValInt_ThrowException()
        {
            int[] testArray = new int[] {2, 2, 2, 2, 2 };

            Assert.That(() => Program.GivenAnArrayReturnsClosestToZero(testArray), Throws.TypeOf<ArgumentException>().With.Message.Contains("Array is made of same integers, please provide variety"));
        }









    }
}
