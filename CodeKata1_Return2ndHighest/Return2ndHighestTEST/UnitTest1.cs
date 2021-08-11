using NUnit.Framework;
using CodeAlongTest_TrainerNishant;
using System;

namespace Return2ndHighestTEST
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        // test for multiple arrays, it must return 2nd highest

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 9)]
        [TestCase(new int[] { 1, 2, 3, 3, 4, 5, 6, 7, 3, 7, 7 }, 6)]
        [TestCase(new int[] { -1, -2, -3, -3, -4, -5, -6, -7, -3, -7, -7 }, -2)]
        [TestCase(new int[] { 0, 1}, 0)]

        public void FeedingMultipleArraysCheckingResultIsSecondHighestInt(int[] testArrat, int expected)
        {
            Assert.That(() => Program.return2ndHighest(testArrat), Is.EqualTo(expected));
        }

        [Test]
        public void FeedingAnEmptyArrayThrowException()
        {

            int[] emptyArray = new int[0];

            Assert.That(() => Program.return2ndHighest(emptyArray), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Mmmmh this array seems to be empty"));

        }
    }
}