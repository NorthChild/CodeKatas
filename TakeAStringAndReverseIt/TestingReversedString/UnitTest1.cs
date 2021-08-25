using NUnit.Framework;
using TakeAStringAndReverseIt;
using System;

namespace TestingReversedString
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("This is my string", "gnirts ym si sihT")]
        [TestCase("This is another string", "gnirts rehtona si sihT")]
        [TestCase("a", "a")]
        public void TestingThatReceivedStringIsReversedCorrectly(string testString, string expected)
        {
            Assert.That(() => Program.TakeStringAndReverseIt(testString), Is.EqualTo(expected));
        }

        [Test]
        public void TestingThatFeedingEmptyStringThrowsException()
        {
            var emptyTestString = "";
            Assert.That(() => Program.TakeStringAndReverseIt(emptyTestString), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("string is empty"));
        }


        // other method 
        [TestCase("This is my string", "gnirts ym si sihT")]
        [TestCase("This is another string", "gnirts rehtona si sihT")]
        [TestCase("a", "a")]
        public void TestingThatReceivedStringIsReversedCorrectlyOtherMethod(string testString, string expected)
        {
            Assert.That(() => Program.TakeAStringAndReverseItOtherMethod(testString), Is.EqualTo(expected));
        }

        [Test]
        public void TestingThatFeedingEmptyStringThrowsExceptionOtherMethod()
        {
            var emptyTestString = "";
            Assert.That(() => Program.TakeAStringAndReverseItOtherMethod(emptyTestString), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("string is empty"));
        }
    }
}