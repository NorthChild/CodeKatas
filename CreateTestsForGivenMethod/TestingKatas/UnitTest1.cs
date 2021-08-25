using NUnit.Framework;
using CreateTestsForGivenMethod;
using System;

namespace TestingKatas
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new int[] { 1,2,3,4,5,6,7,8,9,100 }, 99)]
        [TestCase(new int[] { -1, -2, -3, -4, -5, -6, -7, -8, -9, -100 }, 99)]
        public void TestingThatGivenArrayReturnsMaximumDistanceBetweenElements(int[] testArray, int expected) 
        {

            Assert.That(() => Program.DiffBetweenTwoElements(testArray), Is.EqualTo(expected));
            
        }

        [Test]
        public void TestThatGivenAnEmptyArrayThrowsException() 
        {
            int[] emptyArray = new int[] { };

            Assert.That(() => Program.DiffBetweenTwoElements(emptyArray), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("array is empty!"));
        }

    }
}