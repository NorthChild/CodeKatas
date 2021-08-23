using NUnit.Framework;
using ReturnFibonacciSum;
using System.Collections.Generic;
using System;

namespace FibonacciTEST
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(15, 33)]
        [TestCase(81, 143)]
        [TestCase(110, 232)]
        [TestCase(0, 0)]
        [TestCase(1, 2)]
        public void TestingThatGivenANumberReturnsSumOfFibonacciNumbersFromStartToNthIncluded(int number, int expected)
        {
            Assert.That(() => Program.FibonacciSumOfIntsNthIncluded(number), Is.EqualTo(expected) );
        }


        [Test]
        public void TestingThatFeedingNegativeIntegersThrowsException()
        {
            Assert.That(() => Program.FibonacciSumOfIntsNthIncluded(-2), Throws.TypeOf<Exception>().With.Message.Contains("Number must be positive"));
        }
    }
}